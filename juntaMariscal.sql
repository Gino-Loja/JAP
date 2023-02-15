



create database junta_mariscal;
use junta_mariscal;

CREATE TABLE usuarios(
	id varchar(10) NOT NULL,
    nombre varchar(120) NOT NULL,
    comunidad varchar(50) NOT NULL,
    edad tinyint NOT NULL,
    discapacidad varchar (2) not null,
    PRIMARY KEY (id)
    
)engine = InnoDB;


CREATE TABLE lectura(
	id_l varchar(10) NOT NULL,
    lectura varchar(10) NOT NULL,
    mes varchar(10) NOT NULL,
    anio varchar(50) NOT NULL,
    constraint fk_usuarios_lectura foreign key(id_l)
    references usuarios(id)
)engine = InnoDB;
-- hasta aqui

-- CREATE TABLE consumo_x_mes(
-- 	id_c varchar(10) NOT NULL,
--     consumo varchar(10) NOT NULL,
--     exceso varchar(10) NOT NULL,
--     mes_lectura varchar(10) NOT NULL,
--     PRIMARY KEY (id_c),
--     constraint fk_usuarios_lectura foreign key(id_l)
--     references usuarios(id)
-- )engine = InnoDB;



CREATE TABLE pagos_agua(
	id_p varchar(10) NOT NULL,
    debe int NOT NULL,
    fecha date NOT NULL,
    PRIMARY KEY (id_p),
    constraint fk_usuarios_pagos_agua foreign key(id_p)
    references usuarios(id)
)engine = InnoDB;

CREATE TABLE multas_sesiones(
	id_m varchar(10) NOT NULL,
    debe int NOT NULL,
    fecha date NOT NULL,
    PRIMARY KEY (id_m),
    constraint fk_usuarios_multas_sesiones foreign key(id_p)
    references usuarios(id)
)engine = InnoDB;


select * from lectura;
select * from lectura where id_l = '2200475529';
show tables from chat;

show databases;
