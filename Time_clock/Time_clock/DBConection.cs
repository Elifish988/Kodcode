using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_clock
{
    internal class DBConection
    {
        static SqlConnection _sqlConnection;
        static string connectionString = "server = DESKTOP-0A6MP22\\SQLSERVER;initial catalog=Employes; user id=sa; password=1234;TrustServerCertificate=Yes";

        //פונקציה שמחברת את ה SQL ומחזירה תשובה האם הוא מחובר
        public static bool Connect()
        {
            try
            {
                //בדיקה האם יש חיבור
                if(_sqlConnection == null)
                {
                    //יצירת חיבור
                    _sqlConnection = new SqlConnection(connectionString);
                }
                //חיבור לdb
                _sqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static SqlDataReader runSQlAllResult(string sql, string[] parameters = null, string[] values = null)
        {
            //בודק האם חובר
            if (Connect())
            {
                try
                {
                    //SqlCommand שיגור שאילתה על ידי 
                    SqlCommand cmd = new SqlCommand();
                    //בודק איזה דאטה בייס
                    cmd.Connection = _sqlConnection;
                    //בודק איזה שאילתה
                    cmd.CommandText = sql;
                    // Add parameters
                    //null בדיקה שהפרמטרים אינם
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            // מחבר בין פרמטרים לווליוס AddWithValue 
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }


                    }
                    //מחזיר שורה ראשונה
                    return cmd.ExecuteReader();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            return null;
        }

        //public static string runSQLNoResult(string sql, string[] parameters = null, string[] values = null)
        //{

       // }



        public static string runSQLsingleResolt(string sql, string[] parameters = null , string[] values = null)
        {
            //בודק חיבור
            if (Connect())
            {
                try
                {
                    //
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = _sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if(parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    //מחזיר שורה ראשונה וקוביה ראשונה
                    return cmd.ExecuteScalar().ToString();
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            return "";
        }
    }
}
