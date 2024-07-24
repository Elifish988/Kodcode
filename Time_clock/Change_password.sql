select * from Employes left join Passwords on Employes.Code = Passwords.Employe_Code ;

-- הצהרות
declare @Id varchar(10), @Old_password varchar(30), @new_password varchar(30), @Password_authentication varchar(30), @code int, @answer VARCHAR(250);



select  @Id = '0001', @Old_password = '12', @new_password = '123', @Password_authentication = '123';

-- בדיקת מספר זהות
if exists (select * from Employes where @Id = Employ_id)
	begin
		select @code = (select Code from Employes where @Id = Employ_id);
			
			if exists (select * from Passwords 
			where @code = Employe_Code
			and User_password = @Old_password
			and Is_active = 1)
			begin 
				if not exists (select * from Passwords 
				where @code = Employe_Code
				and User_password = @new_password)
				begin
					if exists (select * from Passwords 
					where @code = Employe_Code
					and User_password = @Old_password
					and	@new_password = @Password_authentication)
						begin
							UPDATE Passwords SET Is_active = 0 where @code = Employe_Code 
							insert into Passwords values (@new_password ,DATEADD(day, 180, GETDATE()) ,@code , 1);
							select @answer = 'Password saved successfully';
						end

					else 
						begin
							select @answer = 'Incorrect password verification';
						end
					end

				else
					begin
						select @answer = 'A password previously existed';
					end
				end
			else
				begin
					select @answer = 'Incorrect password';
				end
	end
else 
	begin
		 select @answer = 'ID number does not exist';
	end

	select @answer