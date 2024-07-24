using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_clock
{
    internal class EmployeeManager
    {
        private static string _loginSQL = "declare  @code int, @answer VARCHAR(250), @fullName VARCHAR(20)='';\r\n--INSERT INTO Employes (Full_name, Employ_id) VALUES (@fulName, @id);\r\n\r\n\r\n-- האם הוא קיים, משיכה של קוד\r\nIF exists (select * from Employes WHERE Employ_id = @id)\r\n\tBEGIN\r\n\t\tSELECT @code = (SELECT Code FROM Employes WHERE Employ_id = @id);\r\n\tEND\r\nELSE\r\n\tBEGIN\r\n\t\t--הוספת עובד לטבלה\r\n\t\tINSERT INTO Employes VALUES (@fullName, @ID);\r\n\t\tSELECT @code = @@IDENTITY;\r\n\tEND\r\n\r\n\r\n\r\n--בדיקת סיסמה\r\nIF exists (select * from Passwords WHERE Employe_Code = @code)\r\n\tBEGIN\r\n\t\tIF exists (SELECT User_password FROM Passwords\r\n\t\t\t\t\tWHERE Employe_Code = @code \r\n\t\t\t\t\tAND User_password = @passwords\r\n\t\t\t\t\tAND Is_active = 1 )\r\n\t\t\tBEGIN\r\n\t\t\t\tIF exists (SELECT User_password FROM Passwords\r\n\t\t\t\t\t\t\tWHERE Employe_Code = @code \r\n\t\t\t\t\t\t\tAND User_password = @passwords\r\n\t\t\t\t\t\t\tAND Is_active = 1\r\n\t\t\t\t\t\t\tAND Password_expiry_date >= GETDATE())\r\n\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t-- בדיקת כניסה ויציאה\r\n\t\t\t\t\t\t\t\tif  exists (SELECT * FROM Time_clock WHERE Employe_Code = @code \r\n\t\t\t\t\t\t\t\t\tAND leaving_time is null)\r\n\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t--עדכון\r\n\t\t\t\t\t\t\t\t\t\t\tUPDATE Time_clock SET leaving_time = GETDATE() WHERE Employe_Code = @code AND leaving_time is null;\r\n\t\t\t\t\t\t\t\t\t\t\tSELECT @answer = 'exit time' + CONVERT (NVARCHAR , GETDATE(), 121);\r\n\t\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\t\tELSE \r\n\t\t\t\t\t\t\t\tBEGIN \r\n\t\t\t\t\t\t\t\t\tINSERT INTO  Time_clock VALUES (GETDATE(), null, @code);\r\n\t\t\t\t\t\t\t\t\tSELECT @answer = 'Entry time' + CONVERT (NVARCHAR , GETDATE(), 121);\r\n\t\t\t\t\t\t\t\tEND \r\n\r\n\t\t\t\t\t\t\tEND\r\n\r\n\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\tSELECT @answer = 'You need to update password';\r\n\t\t\t\t\t\t\t\tEND\r\n\t\t\tEND\r\n\t\t\t\tELSE\r\n\t\t\t\tBEGIN\r\n\t\t\t\t\tSELECT @answer = 'wrong password';\r\n\t\t\t\tEND\r\n\tEND \r\nelse\r\n\tBEGIN \r\n\t\tINSERT INTO Passwords VALUES (@passwords,DATEADD(day, 180, GETDATE()) ,@code , 1);\r\n\t\tSELECT @answer = 'You create A worker and password';\r\n\tEND\r\n\r\n\r\nselect @answer";

        private static string _changePasswordSQL = "declare @code int, @answer VARCHAR(250);\r\n\r\n\r\n\r\n\r\n\r\n-- בדיקת מספר זהות\r\nif exists (select * from Employes where @Id = Employ_id)\r\n\tbegin\r\n\t\tselect @code = (select Code from Employes where @Id = Employ_id);\r\n\t\t\t\r\n\t\t\tif exists (select * from Passwords \r\n\t\t\twhere @code = Employe_Code\r\n\t\t\tand User_password = @Old_password\r\n\t\t\tand Is_active = 1)\r\n\t\t\tbegin \r\n\t\t\t\tif not exists (select * from Passwords \r\n\t\t\t\twhere @code = Employe_Code\r\n\t\t\t\tand User_password = @new_password)\r\n\t\t\t\tbegin\r\n\t\t\t\t\tif exists (select * from Passwords \r\n\t\t\t\t\twhere @code = Employe_Code\r\n\t\t\t\t\tand User_password = @Old_password\r\n\t\t\t\t\tand\t@new_password = @Password_authentication)\r\n\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\tUPDATE Passwords SET Is_active = 0 where @code = Employe_Code \r\n\t\t\t\t\t\t\tinsert into Passwords values (@new_password ,DATEADD(day, 180, GETDATE()) ,@code , 1);\r\n\t\t\t\t\t\t\tselect @answer = 'Password saved successfully';\r\n\t\t\t\t\t\tend\r\n\r\n\t\t\t\t\telse \r\n\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\tselect @answer = 'Incorrect password verification';\r\n\t\t\t\t\t\tend\r\n\t\t\t\t\tend\r\n\r\n\t\t\t\telse\r\n\t\t\t\t\tbegin\r\n\t\t\t\t\t\tselect @answer = 'A password previously existed';\r\n\t\t\t\t\tend\r\n\t\t\t\tend\r\n\t\t\telse\r\n\t\t\t\tbegin\r\n\t\t\t\t\tselect @answer = 'Incorrect password';\r\n\t\t\t\tend\r\n\tend\r\nelse \r\n\tbegin\r\n\t\t select @answer = 'ID number does not exist';\r\n\tend\r\n\r\n\tselect @answer";
        public void doX()
        {
        }
        public static string Login(string id, string password)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@id", "@passwords" };
            string[] values = { id, password };
            string res = DBConection.runSQLsingleResolt(_loginSQL, parameters, values);
            // 3. Return response
            return res;
        }
        public static string ChangePassword(string id, string oldPass, string newPass, string confirmPass)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@Id" , "@Old_password" , "@new_password" , "@Password_authentication" };
            string[] values = { id, oldPass, newPass, confirmPass };
            // 3. Return response
            string res = DBConection.runSQLsingleResolt(_changePasswordSQL, parameters, values);
            return res;
        }
    }

    

}
