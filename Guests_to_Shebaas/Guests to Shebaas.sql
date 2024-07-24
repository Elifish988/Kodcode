create table Guests(
Guetst_code int primary key identity,
Guetst_name varchar(30));

create table Categories(
Category_code int primary key identity,
Category_name varchar(30));

create table Orders(
Orders_code int primary key identity,
Guetst_code int foreign key references Guests,
Category_name int foreign key references Categories,
Meal_name varchar(250)
);


-- enter categry  הכנס קטגוריה
declare @newCategory varchar(250) = 'meet', @answer varchar(250);

if not exists ( select * from Categories where @newCategory = Category_name)
	begin
		insert into Categories VALUES (@newCategory)
		select @answer = 'Category successfully added'
	end

else 
	begin
		select @answer = 'A category exists in the array'
	end

select Category_name from Categories
select @answer


-- get the category (serch by string) חפש שם קטגוריה על פי כתיבה
declare @tmp varchar(250) = 'fish'
select Category_name from Categories
where Category_name like '%' +@tmp + '%'

--add guest הוספת אורח
declare @newGuests varchar(250) = 'יעל פישמן' , @answer varchar(250);

if not exists ( select * from Guests where @newGuests = Guetst_name)
	begin
		insert into Guests VALUES (@newGuests)
		select @answer = 'Guests successfully added'
	end

else 
	begin
		select @answer = 'A Guests exists in the array'
	end 

select Guetst_name from Guests
select @answer


-- add meal הוספת מנה
declare @Guetst_name varchar(30) = 'אלי פישמן', @Category_name varchar(30) = 'meet' , @Meal_name varchar(250) = 'אנטריקוט מיושן בבירה' , @answer varchar(250);

declare  @Guetst_code int , @Category_code int
select @Guetst_code = (select Guetst_code from Guests where  @Guetst_name = Guetst_name)
select @Category_code = (select Category_code from Categories where  @Category_name = Category_name)
if (@Guetst_code is not null and @Category_code is not null)
	begin
		insert into Orders VALUES(@Guetst_code, @Category_code , @Meal_name)
		--select @answer = 'The dish has been ordered successfully'
	end
else 
	begin 
		select @answer = 'Guest or category does not exist'
	end

select * from Orders
select @answer

--כל האוכל שהוזמן מקטגוריה
declare @Category_name varchar(30) = 'fish' , @answer varchar(250) ;

declare @Category_code int;

select @Category_code = (select Category_code from Categories where  @Category_name = Category_name)
select  Orders.Meal_name, count(*) as 'order quantity'
from Orders
where @Category_code = Category_name 
group by Orders.Meal_name

-- כל המנות שהוזמנו על ידי משתמש
declare @Guetst_name varchar(30) = 'אלי פישמן', @Category_name varchar(30) = 'fish'

select Meal_name from Orders
left join Guests on Orders.Guetst_code = Guests.Guetst_code
left join Categories on Orders.Category_name = Categories.Category_code
where Guests.Guetst_name = @Guetst_name
and Categories.Category_name = @Category_name

-- בחירות שאר המתארחים בקטגוריה
declare @Category_name varchar(30) = 'meet', @Guetst_name varchar(30) = 'אלי פישמן'

select Orders.Meal_name ,Guests.Guetst_name from Orders
left join Categories on Categories.Category_code = Orders.Category_name
left join Guests on Guests.Guetst_code = Orders.Guetst_code
where @Category_name = Categories.Category_name
and @Guetst_name != Guests.Guetst_name


select * from Categories
select * from Guests
select * from Orders
