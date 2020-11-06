
use LiveForLife

create table Users
(
  Id int primary key identity(1,1),
  [Login] nvarchar(20),
  [Password] nvarchar(200)
)
drop table Users

create table Users_information
(
  Id_user int primary key,
  foreign key (Id_user) references Users(Id),
  [Name] nvarchar(20),
  Surname nvarchar(20)
)
drop table Users_information

create table Users_adress
(
  Id_adress int primary key,
  foreign key (Id_adress) references Users_information(Id_user),
  Country nvarchar(20),
  City nvarchar(20),
  Street nvarchar(20),
  House int,
  Flat int
)
drop table Users_adress

create table Places
(
  Id int primary key identity(1,1),
  Place_name nvarchar(100),
  Place_adress nvarchar(100),
  Place_type nvarchar(50)
)
drop table Places

create table Wanted_places
(
  Id int primary key identity(1,1),
  Place_id int
  foreign key(Place_id) references Places(Id),
  [User_id] int
  foreign key([User_id]) references Users(Id)
)
drop table Wanted_places

create table Visited_places
(
  Id int primary key identity(1,1),
  Visited_place_id int
  foreign key(Visited_place_id) references Places(Id),
  [V_User_id] int
  foreign key([V_User_id]) references Users(Id)
)
drop table Visited_places

create table Place_information
(
  Id_place int primary key,
  foreign key (Id_place) references Places(Id),
   Place_discriptin text,
  Photo_place varbinary(MAX)
 
)
drop table Place_information

