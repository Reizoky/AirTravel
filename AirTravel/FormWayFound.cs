using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTravel
{
    public partial class FormWayFound : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        public static List<Edge> PrintEdge = PrintEdge = new List<Edge>();

        public FormWayFound()
        {
            InitializeComponent();
        }

        private void FormWayFound_Load(object sender, EventArgs e)
        {
            DB.WorkWithTable(ref dt, "Select Name, IDTown from Town", true);
            DB.WorkWithTable(ref dt2, "Select Name, IDTown from Town", true);

            cbActualPeak.ValueMember = "IDTown";
            cbActualPeak.DisplayMember = "Name";
            cbLastPeak.ValueMember = "IDTown";
            cbLastPeak.DisplayMember = "Name";

            cbActualPeak.DataSource = dt;
            cbLastPeak.DataSource = dt2;
        }

        private void btnWayFound_Click(object sender, EventArgs e)
        {
            PrintEdge = new List<Edge>();
            if (cbLastPeak.SelectedValue == cbActualPeak.SelectedValue)
            {
                MessageBox.Show("Выбирите 2 разных города!");
            }
            else
            {
                int actualPeak = Convert.ToInt32(cbActualPeak.SelectedValue);
                int lastPeak = Convert.ToInt32(cbLastPeak.SelectedValue);

                StringBuilder sb = new StringBuilder();
                DB.WorkWithTable(ref dt3, "Select IDTown1, IDTown2, Name, Cost from Edge", true);
                string nameEdge = string.Empty;
                int Cost = 0;
                bool end = true;
                int[] arrID = new int[1];
                List<Edge> arrWaysIndices = Way.Found(actualPeak, lastPeak, ref end);
                List<Edge> arrWays = new List<Edge>();
                int sp, ep;
                bool CostFine = false;
                for (int i = 0; i < arrWaysIndices.Count; i++)
                {                    
                    sp = Way.ConvertIndexinID(arrWaysIndices[i].startPeak);
                    ep = Way.ConvertIndexinID(arrWaysIndices[i].endPeak);
                    Name = Way.GetNameEdge(sp, ep);
                    arrWays.Add(new Edge(sp, ep, arrWaysIndices[i].cost,Way.GetNameEdge(sp,ep)));
                }
                
                if (!end)
                {
                    do
                    {
                        foreach (Edge ed in arrWays)
                        {
                            if (ed.endPeak == lastPeak)
                            {
                                sb.Insert(0, ed.name + Environment.NewLine);
                                lastPeak = ed.startPeak;
                                PrintEdge.Add(ed);
                                arrWays.Remove(ed);
                                if(!CostFine)
                                {
                                    Cost = ed.cost;
                                    CostFine = true;
                                }
                                break;
                            }
                        }
                    }while (actualPeak != lastPeak) ;
                    sb.Append(Environment.NewLine + Cost.ToString());
                    MessageBox.Show(sb.ToString());
                
                }
                else
                    MessageBox.Show("Пути не существует (или его у нас нет)");

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

/*
                //if (!end)
                //{
                //    int lPeak = lastPeak, aPeak = actualPeak;
                //    for (int i = 0; i < arrID.Length; i++)
                //    {
                //        if (arrID[i] == lPeak)
                //            lastPeak = i;
                //        if (arrID[i] == aPeak)
                //            actualPeak = i;
                //    }

                //    int[] wayPeak = new int[arrWays.Count * 2];
                //    int c = wayPeak.Length - 1; //счетчик для wayPeak
                //    for (int i = 0; i < wayPeak.Length; i++)
                //        wayPeak[i] = -1;
                //    do
                //    {
                //        for (int i = 0; i < arrWays.Count; i++)
                //        {
                //            if (arrWays[i].endPeak == lastPeak)
                //            {
                //                wayPeak[c--] = arrWays[i].endPeak;
                //                wayPeak[c] = arrWays[i].startPeak;
                //                lastPeak = arrWays[i].startPeak;
                //                break;
                //            }
                //        }
                //    } while (lastPeak != actualPeak);
                //    //перевод индексов городов в соответствие с ID в БД
                //    for (int i = wayPeak.Length - 1; i > 0; i--)
                //        if (wayPeak[i] != -1)
                //            for (int j = 0; j < arrID.Length; j++)
                //                if (wayPeak[i] == j)
                //                {
                //                    wayPeak[i] = arrID[j];
                //                    break;
                //                }
                //                else;
                //        else
                //            break;

                //    if (aPeak > lPeak)
                //        for (int i = wayPeak.Length - 1; i > 0 && wayPeak[i] != -1; i--)
                //        {
                //            foreach (DataRow dr in dt3.Rows)
                //                if (dr.Field<int>(0) == wayPeak[i] && dr.Field<int>(1) == wayPeak[i - 1])
                //                {
                //                    nameEdge = dr.Field<string>(2);
                //                    Cost = dr.Field<int>(3);
                //                    sb.Insert(0, string.Format("{0} - {1}{2}",
                //                        nameEdge, Cost, Environment.NewLine));
                //                    break;
                //                }
                //        }
                //    else
                //    {
                //        for (int i = wayPeak.Length - 1; i > 0 && wayPeak[i] != -1; i--)
                //        {
                //            foreach (DataRow dr in dt3.Rows)
                //                if (dr.Field<int>(1) == wayPeak[i] && dr.Field<int>(0) == wayPeak[i - 1])
                //                {
                //                    nameEdge = dr.Field<string>(2);
                //                    Cost = dr.Field<int>(3);
                //                    sb.Insert(0, string.Format("{0} - {1}{2}",
                //                        nameEdge, Cost, Environment.NewLine));
                //                    break;
                //                }
                //        }
                //    }
                //    way = sb.ToString();
                //}
                //else
                //    way = "Маршрута не существует";
*/
