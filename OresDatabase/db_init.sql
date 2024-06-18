create table if not exists elements(
	_element_id integer not null primary key autoincrement,
	name text not null,
	description text default "No description presented",
	pictures_locations text default "[]",
	gas_temp real default 0,
	fluid_temp real default 0,
	solid_temp real default 0,
	density real default 0,
	viscosity real default 0,
	glowing real default 0
);

-- like bauxite
create table if not exists ore_types(
	_ore_type_id integer not null primary key autoincrement,
	name text not null,
	description text default "No description presented"
);

create table if not exists rock_types(
	_rock_type_id integer not null primary key autoincrement,
	name text not null,
	description text default "No description presented"
);

create table if not exists biomes(
	_biome_id integer not null primary key autoincrement,
	name text not null,
	description text default "No description presented"
);

create table if not exists ores(
	_ore_id integer not null primary key autoincrement,
	_ore_type_id integer not null,
	description text default "No description presented",
	pictures_locations text default "[]",
	height integer default 0,
	frequency real default 0,
	_rock_type_id integer not null,
	_biome_id integer not null
);

create table if not exists ore_elements_info(
	_ore_id integer not null,
	_element_id integer not null,
	percentage real default 0
);