using College;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace College_meneger
{
    internal class Cntrol_Colleg_meneger
    {
        public static DataTable ShoewStudents()
        {
            
            string Sql = "select * from Students";
            //הכנסה למשתנה מסוג דאטא טייבל את התוצאות של אדאפטר
            DataTable reader = DBSConection_meneger.RunSqlTableResul(Sql);
            return reader;
        }
        

        public static DataTable ShoewCurses()
        {

            string Sql = "select * from Courses";
            //הכנסה למשתנה מסוג דאטא טייבל את התוצאות של אדאפטר
            DataTable reader = DBSConection_meneger.RunSqlTableResul(Sql);
            return reader;
        }

        public static void AddCourse(Object[] values)
        {
            string[] parameters = { "@Prase", "@Name", "@date", "@Dase", "@Howers" };   
            string Sql = "insert into Courses  values (@Prase, @Name , @date, @Dase,@Howers)";
            //ביצוע הפעולה בדאטה בייס
            DBSConection_meneger.runSQLNoResult(Sql, parameters, values);

        }

        public static void DellCourse(Object[] values)
        {
            string[] parameters = { "@Courses_name" };
            string Sql = "delete from Courses where @Courses_name = Courses_name";
            //ביצוע הפעולה בדאטה בייס
            DBSConection_meneger.runSQLNoResult(Sql, parameters, values);

        }
    }
}
