CREATE TABLE Employes(
Code INT PRIMARY KEY IDENTITY,
Full_name VARCHAR(30),
Employ_id VARCHAR(10) UNIQUE);

CREATE TABLE Passwords(
Id INT PRIMARY KEY IDENTITY,
User_password VARCHAR(30),
Password_expiry_date DATE,
Employe_Code INT FOREIGN KEY REFERENCES Employes(Code),
Is_active BIT);

CREATE TABLE Time_clock(
Id INT PRIMARY KEY IDENTITY,
entrance_time DATETIME,
leaving_time DATETIME,
Employe_Code INT FOREIGN KEY REFERENCES Employes(Code));



-- מציאת עובד ברשימה ובדיקה האם הוא קיים
 DECLARE @passwords VARCHAR(10)='1234', @id VARCHAR(10)='0004';
declare  @code int, @answer VARCHAR(250), @fullName VARCHAR(20)='';
--INSERT INTO Employes (Full_name, Employ_id) VALUES (@fulName, @id);


-- האם הוא קיים, משיכה של קוד
IF exists (select * from Employes WHERE Employ_id = @id)
	BEGIN
		SELECT @code = (SELECT Code FROM Employes WHERE Employ_id = @id);
	END
ELSE
	BEGIN
		--הוספת עובד לטבלה
		INSERT INTO Employes VALUES (@fullName, @ID);
		SELECT @code = @@IDENTITY;
	END



--בדיקת סיסמה
IF exists (select * from Passwords WHERE Employe_Code = @code)
	BEGIN
		IF exists (SELECT User_password FROM Passwords
					WHERE Employe_Code = @code 
					AND User_password = @passwords
					AND Is_active = 1 )
			BEGIN
				IF exists (SELECT User_password FROM Passwords
							WHERE Employe_Code = @code 
							AND User_password = @passwords
							AND Is_active = 1
							AND Password_expiry_date >= GETDATE())
							BEGIN
								-- בדיקת כניסה ויציאה
								if  exists (SELECT * FROM Time_clock WHERE Employe_Code = @code 
									AND leaving_time is null)
										BEGIN
										--עדכון
											UPDATE Time_clock SET leaving_time = GETDATE() WHERE Employe_Code = @code AND leaving_time is null;
											SELECT @answer = 'exit time' + CONVERT (NVARCHAR , GETDATE(), 121);
										END
								ELSE 
								BEGIN 
									INSERT INTO  Time_clock VALUES (GETDATE(), null, @code);
									SELECT @answer = 'Entry time' + CONVERT (NVARCHAR , GETDATE(), 121);
								END 

							END

							ELSE
								BEGIN
									SELECT @answer = 'You need to update password';
								END
			END
				ELSE
				BEGIN
					SELECT @answer = 'wrong password';
				END
	END 
else
	BEGIN 
		INSERT INTO Passwords VALUES (@passwords,DATEADD(day, 180, GETDATE()) ,@code , 1);
		SELECT @answer = 'You create A worker and password';
	END


select @answer





SELECT * FROM Employes;
SELECT * FROM Passwords;
SELECT * FROM Time_clock;


