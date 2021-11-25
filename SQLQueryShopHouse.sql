create database homedream;

use homedream;

create table houses(

	id_house int primary key,
	nameHouse varchar(50),
	nameSeller varchar(50),
	value int,
	ubication nvarchar (150),
	size nvarchar (100),
	rooms int,
	bathrooms int,
	garages int,
	photoHouse nvarchar (350),
	active bit

);

