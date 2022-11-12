--создание БД для выполнения вопроса № 3
create database Testing_Task_MINDBOX;
go
use Testing_Task_MINDBOX;
create table Products(
	ID int identity(1,1),
	Name nvarchar(50) not null,
	constraint Product_PK primary key (ID)
	);

create table Categories(
	ID int identity(1,1),
	Name nvarchar(50) not null
	constraint Category_PK primary key (ID)
	);
go
create table Product_Category(
	Product_ID int,
	Category_ID int,
	constraint fk_Product_id foreign key (Product_ID) references Products (ID),
	constraint fk_Category_id foreign key (Category_ID) references Categories (ID)
	);

