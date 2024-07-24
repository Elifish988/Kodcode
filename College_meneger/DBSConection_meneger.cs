using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    internal class DBSConection_meneger
    {
        //משתנה שמחזיק חיבור
        static SqlConnection _sqlConnection;
        //משתנה שמחזיק כתובת לשרת ודאטה בייס
        static string connectionString = "server = DESKTOP-0A6MP22\\SQLSERVER;initial catalog = College ; user id=sa; password=1234;TrustServerCertificate=Yes";

        //פונקציה שפותחת את ה SQL ומחזירה תשובה האם הוא מחובר
        public static bool Connect()
        {
            try
            {
                //בדיקה האם יש חיבור
                if (_sqlConnection == null)
                {
                    //יצירת חיבור
                    _sqlConnection = new SqlConnection(connectionString);
                }
                //פתיחה של דאטה בייס במקרה והוא סגור
                if (_sqlConnection.State.ToString() != "Open")
                {
                    _sqlConnection.Open();
                }

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
                    //יוצר משתנה לניהול הדאטה בייס 
                    SqlCommand cmd = new SqlCommand();
                    //מתחבר לדאטה בייס
                    cmd.Connection = _sqlConnection;
                    //שולח שאילתה
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
                    SqlDataReader result = cmd.ExecuteReader();
                    //מחזיר שורה ראשונה
                    return result;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            return null;



        }

        public static string runSQLNoResult(string sql, string[] parameters = null, Object[] values = null)
        {
            if (Connect())
            {
                try
                {
                    // מקשר לדאטה בייס ושולח בקשות
                    SqlCommand cmd = new SqlCommand();
                    //יוצר חיבור
                    cmd.Connection = _sqlConnection;
                    // שולח שאלה
                    cmd.CommandText = sql;
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            //מחבר פרמטרים
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    //  מבצע את הפעולה לcmd 
                    cmd.ExecuteNonQuery();



                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }

            }
            return null;
        }

        public static DataTable RunSqlTableResul(string sql, string[] parameters = null, string[] values = null)
        {

            if (Connect())
            {
                try
                {
                    // מקשר לדאטה בייס ושולח בקשות
                    SqlCommand cmd = new SqlCommand();
                    //יוצר חיבור
                    cmd.Connection = _sqlConnection;
                    // שולח שאלה
                    cmd.CommandText = sql;
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            //מחבר פרמטרים
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    //  גמקבל את החיבור לcmd 
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    //מכניס לטייפ דאטה טייבל
                    DataTable dataTable = new DataTable();
                    //מילוי הנתונים(fill) בדאטה טייבל
                    adapter.Fill(dataTable);
                    return dataTable;


                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }

            }
            return null;
        }
    }
}
