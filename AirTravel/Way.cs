using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Linq;

namespace AirTravel
{
    class Way
    {
        static int[,] map;
        static int[] arrID;//сопоставление индексов и ID городов
        static int[,] arrEdge;//ID городов и стоимость
        static int actualPeak;//текущая вершина
        static int lastPeak;//конечный пункт назначения
        static int[,] arrIDIndices;//массив сопоставления ID и индексов

        static DataTable dt;
       
        public static List<Edge> Found(int actualPeak, int lastPeak, ref bool end)
        {
            CreateMap(actualPeak, lastPeak);
            //нахождение пути
            List<Edge> arrWays = new List<Edge>();
            int startPeak = ConvertIDinIndex(actualPeak);
            bool flag = false;
            bool[] mark = new bool[map.GetLength(0)]; //помеченные вершины
            bool inArrWays; //находится ли в массиве ребер
            int costPeak = 0; //стоимость пути
            int delPeak = 0;
            int testPeak = 0;
            int costTest = 0;//для теста при наличии в массиве ребер
            actualPeak = ConvertIDinIndex(actualPeak);
            lastPeak = ConvertIDinIndex(lastPeak);
            //нахождение пути или недостижимость
            while (!mark[lastPeak])
            {
                mark[actualPeak] = true; //пометить текущую вершину
                //начало цикла на достижимость
                for (int j = 0; j < map.GetLength(0); j++)//j - столбец
                {
                    inArrWays = false;
                    if (!mark[j] && (map[actualPeak, j] > 0 || map[j, actualPeak] > 0) && j != startPeak)//вершина не помечена и достижима
                    {
                        //цикл находится ли в массиве ребер
                        for (int k = 0; k < arrWays.Count; k++)
                        {
                            if (j == arrWays[k].endPeak)
                            {
                                inArrWays = true;
                                testPeak = j;
                                costPeak = arrWays[k].cost;
                                delPeak = k;
                                break;
                            }
                        }

                        for (int z = 0; z < arrWays.Count; z++)
                        {
                            if (arrWays[z].endPeak == actualPeak)
                                costTest = arrWays[z].cost;
                        }
                        //проверка, находится ли в массиве ребер
                        if (inArrWays)
                        {

                            if (costTest + map[actualPeak, testPeak] < costPeak)
                            {
                                arrWays.RemoveAt(delPeak);
                                arrWays.Add(new Edge(actualPeak, j, costTest + map[actualPeak, testPeak], "1"));
                            }
                        }
                        else
                            arrWays.Add(new Edge(actualPeak, j, costTest + map[actualPeak, j], "1")); //добавление, если нет в массиве ребер
                    }
                }//конец цикла на достижимость
                
                bool reActualPeak = false;
                int minWeight = Int32.MaxValue;
                int newActualPeak = actualPeak;
                for (int n = 0; n < arrWays.Count; n++)
                {
                    if (arrWays[n].cost < minWeight
                        && arrWays[n].startPeak == actualPeak
                        && !mark[arrWays[n].endPeak]
                        && arrWays[n].endPeak != startPeak)
                    {
                        minWeight = arrWays[n].cost;
                        newActualPeak = arrWays[n].endPeak;
                        reActualPeak = true;
                        flag = false;
                    }
                }

                if (flag)
                {
                    end = true;
                    return arrWays;
                }

                if (reActualPeak)
                {
                    mark[actualPeak] = false;
                    actualPeak = newActualPeak;
                }
                else
                {
                    actualPeak = startPeak;
                    flag = true;
                }
            }
            end = false;
            return arrWays;
        }

        public static void CreateMap(int _actualPeak, int _lastPeak)
        {
            dt = new DataTable();
            int i, j;
            //нахождение количества городов
            DB.WorkWithTable(ref dt, "select IDTown from town", true);
            int[] arrID = new int[dt.Rows.Count];
            //полуение списка ID
            i = 0;
            foreach (DataRow dr in dt.Rows)
                arrID[i++] = dr.Field<int>(0);
            //сопоставление ID и индексов
            arrIDIndices = createArrIDInIndex(arrID);
            int arrIDIndicesSize = arrIDIndices.GetLength(0);
            //нахождение количество ребер и стоимость
            dt = new DataTable();
            DB.WorkWithTable(ref dt, "Select IDTown1, IDTown2, Cost, Name from Edge", true);
            i = 0;
            arrEdge = new int[dt.Rows.Count, 3];
            foreach (DataRow dr in dt.Rows)
            {
                arrEdge[i, 0] = dr.Field<int>(0);
                arrEdge[i, 1] = dr.Field<int>(1);
                arrEdge[i, 2] = dr.Field<int>(2);
                i++;
            }
            //замена ID на индексы в arrEdge
            for (i = 0; i < arrEdge.GetLength(0); i++)
            {
                arrEdge[i, 0] = ConvertIDinIndex(arrEdge[i, 0]);
                arrEdge[i, 1] = ConvertIDinIndex(arrEdge[i, 1]);
            }
            //создание карты
            map = new int[arrID.GetLength(0), arrIDIndicesSize];
            //заполнение карты
            for (i = 0; i < arrIDIndicesSize; i++)
                for (j = 0; j < arrIDIndicesSize; j++)
                    map[i, j] = (i == j) ? 0 : -1;
            for (i = 0; i < arrEdge.GetLength(0); i++)
            {
                map[arrEdge[i, 0], arrEdge[i, 1]] = arrEdge[i, 2];
                map[arrEdge[i, 1], arrEdge[i, 0]] = arrEdge[i, 2];
            }
        }

        public static int[,] createArrIDInIndex(int[] _arrIndices)
        {
            int[,] _arrIDIndices = new int[_arrIndices.Length, 2];
            int ch = 0;
            foreach (int i in _arrIndices)
            {
                _arrIDIndices[ch, 0] = ch;
                _arrIDIndices[ch, 1] = _arrIndices[ch];
                ch++;
            }
            return _arrIDIndices;
        }

        public static int ConvertIDinIndex(int id)
        {
            int index = 0;
            for (int i = 0; i < arrIDIndices.GetLength(0); i++)
                if (arrIDIndices[i, 1] == id)
                {
                    index = i;
                    break;
                }
            return index;
        }

        public static int ConvertIndexinID(int index)
        {
            int id = 0;
            for (int i = 0; i < arrIDIndices.GetLength(0); i++)
                if (i == index)
                {
                    id = arrIDIndices[i, 1];
                    break;
                }
            return id;
        }

        public static string GetNameEdge(int _sp, int _ep)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if ((dr.Field<int>(0) == _sp && dr.Field<int>(1) == _ep) ||
                   (dr.Field<int>(0) == _ep && dr.Field<int>(1) == _sp))
                    return dr.Field<string>(3);
            }
            return "не найден";
        }

    }
}
