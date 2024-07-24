using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    internal class Control_College
    {
        //רשימת שמות
        public static List<string> GetNams()
        {
            //בקשה לשרת 
            string Sql = "select Student_name  from Students";
            //קבלת השורות למשתנה
            SqlDataReader reader = DBSConection.runSQlAllResult(Sql);
            //יצירת רשימה
            List<string> categries = new List<string>();
            // הכנסת כל שורה לבוקסט ליסט
            for (int i = 0; reader.Read(); i++)
            {
                categries.Add(reader.GetString(0));
            }
            //runSQlAllResultסגירת ה
            reader.Close();
            //החזרת הערכים
            return categries;
        }

        public static string GetId(string name)
        {
            string[] values = { name };
            string[] parameters = { "@Student_name" };
            string Sql = "select Student_id  from Students where @Student_name = Student_name ";
            //קבלת השורות למשתנה
            string reader = DBSConection.runSQLsingleResolt(Sql, parameters, values);

            //החזרת הערכים
            return reader;
        }

        //מציאת שם לפי אות
        public static List<string> SelectNams(string[] parameters, string[] values)
        {
            //בקשה לשרת
            string Sql = "select Student_name  from Students\r\nwhere Student_name like '%' + @Letter + '%'";
            //קבלת משתנים
            SqlDataReader reader = DBSConection.runSQlAllResult(Sql, parameters, values);
            List<string> categries = new List<string>();
            for (int i = 0; reader.Read(); i++)
            {
                categries.Add(reader.GetString(0));
            }
            reader.Close();
            return categries;
        }

        public static void AddName(string[] values)
        {
            string[] parameters = { "@newName" , "@newId" };
            string Sql = "if not exists ( select * from Students where @newName = Student_name)\r\ninsert into Students VALUES (@newName, @newId, null)\r\n";
            //ביצוע הפעולה בדאטה בייס
            DBSConection.runSQLNoResult(Sql, parameters, values);
        }

        public static List<string> GetCourses()
        {
            //בקשה לשרת 
            string Sql = "select Courses_name  from Courses";
            //קבלת השורות למשתנה
            SqlDataReader reader = DBSConection.runSQlAllResult(Sql);
            //יצירת רשימה
            List<string> categries = new List<string>();
            // הכנסת כל שורה לבוקסט ליסט
            for (int i = 0; reader.Read(); i++)
            {
                categries.Add(reader.GetString(0));
            }
            //runSQlAllResultסגירת ה
            reader.Close();
            //החזרת הערכים
            return categries;
        }

        public static List<string> GetCoursesMy( string name)
        {
            string[] values = { name };
            string[] parameters = { "@Student_name" };
            //בקשה לשרת 
            string Sql = "select Courses_name  from Courses \r\nleft join Registration on Registration.Courses_code = Courses.Courses_code\r\nleft join Students on Students.Student_code = Registration.Student_code\r\nwhere Students.Student_name = @Student_name ";
            //קבלת השורות למשתנה
            SqlDataReader reader = DBSConection.runSQlAllResult(Sql , parameters , values);
            //יצירת רשימה
            List<string> categries = new List<string>();
            // הכנסת כל שורה לבוקסט ליסט
            for (int i = 0; reader.Read(); i++)
            {
                categries.Add(reader.GetString(0));
            }
            //runSQlAllResultסגירת ה
            reader.Close();
            //החזרת הערכים
            return categries;
        }

        public static void AddCourse(string[] values)
        {
            string[] parameters = { "@Student_name", "@Courses_name" };
            string Sql = "declare @Student_code int , @Courses_code int ;\r\nselect @Student_code = (select Student_code from Students where  @Student_name = Student_name)\r\nselect @Courses_code = (select Courses_code from Courses where @Courses_name = Courses_name)\r\n\r\ninsert into Registration values (@Student_code, @Courses_code)\r\ndeclare @sum int = (select Course_price from Courses where @Courses_code = Courses_code)\r\ninsert into Payment_table values (@Student_code, 1 , @sum)\r\nif ((select sum (Total) from Payment_table where @Student_code = Payment_table.Student_code  and is_equired = 0) is not null)\r\nbegin\r\nupdate Students set Amount_to_pay = \r\n((select sum (Total) from Payment_table where @Student_code = Payment_table.Student_code  and is_equired = 1)\r\n- (select sum (Total) from Payment_table where @Student_code = Payment_table.Student_code  and is_equired = 0))\r\nwhere @Student_code = Student_code\r\nend\r\nelse\r\nbegin\r\nupdate Students set Amount_to_pay = \r\n(select sum (Total) from Payment_table where @Student_code = Payment_table.Student_code  and is_equired = 1)\r\nwhere @Student_code = Student_code\r\nend";
            //ביצוע הפעולה בדאטה בייס
            DBSConection.runSQLNoResult(Sql, parameters, values);
        }

        public static string GetSum( string name)
        {
            string[] values = { name };
            string[] parameters = { "@Student_name" } ;
            string Sql = "select Amount_to_pay  from Students where @Student_name = Student_name ";
            //קבלת השורות למשתנה
            string reader = DBSConection.runSQLsingleResolt(Sql, parameters, values);
           
            //החזרת הערכים
            return reader;
        }

        public static void AddPay(string[] values)
        {
            string[] parameters = { "@Student_name", "@sum" };
            string Sql = "declare @Student_code int\r\nselect @Student_code = (select Student_code from Students where Student_name = @Student_name)\r\ninsert into Payment_table values (@Student_code, 0 , @sum)\r\nif ((select sum (Total) from Payment_table where @Student_code = Payment_table.Student_code  and is_equired = 0) is not null)\r\nbegin\r\nupdate Students set Amount_to_pay = \r\n((select sum (Total) from Payment_table where @Student_code = Payment_table.Student_code  and is_equired = 1)\r\n- (select sum (Total) from Payment_table where @Student_code = Payment_table.Student_code  and is_equired = 0))\r\nwhere @Student_code = Student_code\r\nend\r\nelse\r\nbegin\r\nupdate Students set Amount_to_pay = \r\n(select sum (Total) from Payment_table where @Student_code = Payment_table.Student_code  and is_equired = 1)\r\nwhere @Student_code = Student_code\r\nend";
            //ביצוע הפעולה בדאטה בייס
            DBSConection.runSQLNoResult(Sql, parameters, values);
        }


    }
}
