using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AirTravel
{
    class DB
    {
        static string strConn;
        public static SqlConnection sConn = new SqlConnection();
        public static SqlDataAdapter sDataAdapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public static string login;
        public static string password;

        public static void CreateStringConnection(string _login, string _password)
        {
            strConn = @"Data Source=" + Properties.Settings.Default.serverName + ";Initial Catalog=AirTravel;User ID=" + _login + ";Password=" + _password;
            try
            {
                sConn.Close();
                sConn.ConnectionString = strConn;
                sConn.Open();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        public string StringConnection
        {
            get { return strConn; }
        }

        public static void WorkWithTable(ref DataTable _dt, string _sqlSelect, bool select)
        {
            using (SqlConnection sConn = new SqlConnection(DB.strConn))
            {
                try
                {
                    sConn.Open();
                    SqlDataAdapter sDA = new SqlDataAdapter(_sqlSelect, sConn);

                    if (!select)
                    {
                        SqlCommandBuilder sCB = new SqlCommandBuilder(sDA);
                        sDA.Update(_dt);
                    }
                    _dt.Clear();
                    sDA.Fill(_dt);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        public static void DoDMLCommand(string sqlCommand)
        {
            using (SqlConnection sConn = new SqlConnection(DB.strConn))
            {
                sConn.Open();
                try
                {
                    SqlCommand sComm = new SqlCommand(sqlCommand, sConn);
                    sComm.ExecuteNonQuery();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        public static void GetSchemaDB(ref DataTable _dt)
        {
            using (SqlConnection sConn = new SqlConnection(DB.strConn))
            {
                try
                {
                    sConn.Open();
                    _dt = sConn.GetSchema("Tables");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
        public static void DoSql(string[] commandsArr)
        {
            using (SqlConnection sConn = new SqlConnection(DB.strConn))
            {
                sConn.Open();
                SqlTransaction sTrans = sConn.BeginTransaction();
                try
                {
                    foreach (string sqlCommand in commandsArr)
                    {
                        if (sqlCommand != string.Empty)
                        {
                            SqlCommand sComm = new SqlCommand(sqlCommand, sConn,sTrans);
                            int strCount = sComm.ExecuteNonQuery();
                            MessageBox.Show("Команда "+Environment.NewLine + sqlCommand +
                                Environment.NewLine + Environment.NewLine + "выполнена успешно. "
                                + "Количество обработанных строк - " + strCount);
                        }
                    }
                    sTrans.Commit();
                }
                catch (Exception ex)
                {
                    sTrans.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
