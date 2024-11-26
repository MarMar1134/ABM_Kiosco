CREATE schema if not exists sistema_ventas;
drop schema if exists sistema_ventas;

USE sistema_ventas;

CREATE TABLE kiosco (
  idkiosco INT PRIMARY KEY,
  nombre VARCHAR(45) NOT NULL,
  dirección VARCHAR(45) NOT NULL,
  teléfono VARCHAR(45) NOT NULL
);

CREATE TABLE usuario (
  idusuario INT PRIMARY KEY,
  nombre VARCHAR(45) NOT NULL,
  rol VARCHAR(45) NOT NULL,
  contraseña VARCHAR(45) NOT NULL,
  kiosco_idkiosco INT NOT NULL,
  FOREIGN KEY (kiosco_idkiosco) REFERENCES kiosco(idkiosco)
);

CREATE TABLE productos (
  idproductos INT PRIMARY KEY,
  nombre VARCHAR(45) NOT NULL,
  descripción VARCHAR(45) NOT NULL,
  precio VARCHAR(45) NOT NULL,
  cantidad VARCHAR(45) NOT NULL,
  categoría VARCHAR(45) NOT NULL
);

CREATE TABLE ventas (
  idventas INT PRIMARY KEY,
  fecha VARCHAR(45) NOT NULL,
  total VARCHAR(45) NOT NULL,
  productos_vendidos VARCHAR(45) NOT NULL,
  kiosco_idkiosco INT NOT NULL,
  FOREIGN KEY (kiosco_idkiosco) REFERENCES kiosco(idkiosco)
);

CREATE TABLE productos_has_ventas (
  productos_idproductos INT NOT NULL,
  ventas_idventas INT NOT NULL,
  PRIMARY KEY (productos_idproductos, ventas_idventas),
  FOREIGN KEY (productos_idproductos) REFERENCES productos(idproductos),
  FOREIGN KEY (ventas_idventas) REFERENCES ventas(idventas)
);