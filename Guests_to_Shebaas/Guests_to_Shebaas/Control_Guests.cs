using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests_to_Shebaas
{
    internal class Control_Guests
    {
        //שולחת שמות לטבלה
        public static List<string> GetNams()
        {
            //בקשה לשרת 
            string Sql = "select Guetst_name  from Guests";
            //קבלת השורות למשתנה
            SqlDataReader reader = DBSConectionGuests.runSQlAllResult(Sql);
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

        //מציאת שם לפי אות
        public static List<string> SelectNams(string[] parameters, string[] values)
        {
            //בקשה לשרת
            string Sql = "select Guetst_name  from Guests\r\nwhere Guetst_name like '%' + @Letter + '%'";
            //קבלת משתנים
            SqlDataReader reader = DBSConectionGuests.runSQlAllResult(Sql, parameters, values);
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
            string[] parameters = { "@newName" };
            string Sql = "if not exists ( select * from Guests where @newName = Guetst_name)\r\ninsert into Guests VALUES (@newName)\r\n";
            //ביצוע הפעולה בדאטה בייס
            DBSConectionGuests.runSQLNoResult(Sql, parameters, values);
        }

        //מחיקת שם
        public static void DeleteName(string[] values)
        {
            string[] parameters = { "@Guests_name" };
            string Sql = "delete Orders from Orders  join Guests  on   Orders.Guetst_code = Guests.Guetst_code\r\nand Guests.Guetst_name = @Guests_name\r\ndelete from Guests where Guetst_name = @Guests_name\r\n";
            DBSConectionGuests.runSQLNoResult(Sql, parameters, values);

        }

        public static List<string> GetCategoris()
        {
            string Sql = "select Category_name from Categories";
            SqlDataReader reader = DBSConectionGuests.runSQlAllResult(Sql);
            List<string> categries = new List<string>();
            for (int i = 0; reader.Read(); i++)
            {
                categries.Add(reader.GetString(0));
            }
            reader.Close();
            return categries;
        }

        public static DataTable ShoewEveryoneChoice(string[] values) 
        {
            string[] parameters = { "@Category_name" , "@Guetst_name" };
            string Sql = "select Orders.Meal_name ,Guests.Guetst_name from Orders\r\nleft join Categories on Categories.Category_code = Orders.Category_name\r\nleft join Guests on Guests.Guetst_code = Orders.Guetst_code\r\nwhere @Category_name = Categories.Category_name\r\nand @Guetst_name != Guests.Guetst_name";
            //הכנסה למשתנה מסוג דאטא טייבל את התוצאות של אדאפטר
            DataTable reader = DBSConectionGuests.RunSqlTableResul(Sql, parameters, values);
            return reader;
        }

        public static DataTable ShowMyChoice(string[] values)
        {
            string[] parameters = { "@Category_name", "@Guetst_name" };
            string Sql = "select Meal_name from Orders\r\nleft join Guests on Orders.Guetst_code = Guests.Guetst_code\r\nleft join Categories on Orders.Category_name = Categories.Category_code\r\nwhere Guests.Guetst_name = @Guetst_name\r\nand Categories.Category_name = @Category_name";
            //הכנסה למשתנה מסוג דאטא טייבל את התוצאות של אדאפטר
            DataTable reader = DBSConectionGuests.RunSqlTableResul(Sql, parameters, values);
            return reader;
        }

        public static void AddMael(string[] values)
        {
            string[] parameters = { "@Guetst_name", "@Category_name" , "@Meal_name" };
            string Sql = "declare  @Guetst_code int , @Category_code int\r\nselect @Guetst_code = (select Guetst_code from Guests where  @Guetst_name = Guetst_name)\r\nselect @Category_code = (select Category_code from Categories where  @Category_name = Category_name)\r\nif (@Guetst_code is not null and @Category_code is not null)\r\n\tbegin\r\n\t\tinsert into Orders VALUES(@Guetst_code, @Category_code , @Meal_name)\r\n\t\t--select @answer = 'The dish has been ordered successfully'\r\n\tend";
            //ביצוע הפעולה בדאטה בייס
            DBSConectionGuests.runSQLNoResult(Sql, parameters, values);
        }

    }
}
