create table producto(
	id int,
	nombre text,
	precio int,
	stock int,
	sucursal text,
	
	primary key (id)
);

insert into producto(id,nombre,precio,stock,sucursal) values(5,'LapTop',5000,3,'Alameda');

select * from producto;