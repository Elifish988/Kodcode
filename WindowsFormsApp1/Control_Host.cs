using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Control_Host
    {
        public static List<string> GetCategoris()
        {
            string Sql = "select Category_name from Categories";
            SqlDataReader reader = DBConection.runSQlAllResult(Sql);
            List<string> categries = new List<string>();
            for (int i = 0; reader.Read(); i++)
            {
                categries.Add(reader.GetString(0));
            }
            reader.Close();
            return categries;
        }

        public static void DeleteCategoris(string[] values)
        {
            string[] parameters = { "@Guetst_name" };
            string Sql = "delete Orders from Orders  join Categories  on   Orders.Category_name = Category_code\r\nand Categories.Category_name = @Category_name\r\ndelete from Categories where Category_name = @Category_name";
            DBConection.runSQLNoResult(Sql, parameters, values);
            
        }

        public static List<string> SelectCategoris(string[] parameters, string[] values)
        {
            
            string Sql = "select Category_name from Categories\r\nwhere Category_name like '%' + @Letter + '%'";
            SqlDataReader reader = DBConection.runSQlAllResult(Sql, parameters, values);
            List<string> categries = new List<string>();
            for (int i = 0; reader.Read(); i++)
            {
                categries.Add(reader.GetString(0));
            }
            reader.Close();
            return categries;
        }

        public static void AddCategory(string[] values)
        {
            string[] parameters = { "@newCategory" }; 
            string Sql = "if not exists ( select * from Categories where @newCategory = Category_name)\r\n\tbegin\r\n\t\tinsert into Categories VALUES (@newCategory)\r\n\t\t--select @answer = 'Category successfully added'\r\n\tend";
            //ביצוע הפעולה בדאטה בייס
            DBConection.runSQLNoResult(Sql, parameters, values);
        }
        
        public static DataTable ShoeMaels(string[] values)
        {
            string[] parameters = {"@Category_name"};
            string Sql = "declare @Category_code int;\r\n\r\nselect @Category_code = (select Category_code from Categories where  @Category_name = Category_name)\r\nselect  Orders.Meal_name, count(*) as 'order quantity'\r\nfrom Orders\r\nwhere @Category_code = Category_name \r\ngroup by Orders.Meal_name";
            //הכנסה למשתנה מסוג דאטא טייבל את התוצאות של אדאפטר
            DataTable reader = DBConection.RunSqlTableResul(Sql, parameters, values);
            return reader;
        }




    }
}
