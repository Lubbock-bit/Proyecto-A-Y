DROP DATABASE IF EXISTS AyR;
CREATE DATABASE AyR;
USE AyR;

CREATE TABLE Administradores(
idAdm INT AUTO_INCREMENT,
NomApe VARCHAR(100),
dni INT,
tel VARCHAR(15),
mail VARCHAR(20),
CONSTRAINT PK_Administradores PRIMARY KEY(idAdm)
);

INSERT INTO administradores VALUES
('', 'Juan Perez', 8934566, 1569203422, 'juan@yahoo.com'),
('', 'Hermenigilda Zimbawe', 9457516, 1546424988, 'HerZim@outlook.com'),
('', 'Feliciano Robles', 11274689, 1586546254, 'FeliBocaFan96@hotmail.com'),
('', 'Celestino Moyano', 12345678, 1562783654, 'ConLaMano@gmail.com'),
('', 'Amaia Tovar', 1547523, 1545464725, 'AmaMessiLeo@yahoo.com');

CREATE TABLE Edificios(
Nedif INT AUTO_INCREMENT,
idAdm INT, 
direccion VARCHAR(100),
carteleria BOOLEAN,
CONSTRAINT PK_Edificios PRIMARY KEY(Nedif),
CONSTRAINT FK_Edificios_Administradores FOREIGN KEY(idAdm) REFERENCES Administradores(idAdm)
);

INSERT INTO edificios VALUES
('', 3, 'De la amistad 463', FALSE),
('', 5, 'Saavedra 3903', TRUE),
('', 2, 'Balcarce 823', TRUE),
('', 1, 'LaValle 1547', FALSE),
('', 4, 'Bruselas 948', TRUE);

CREATE TABLE Recargas(
Nrec INT AUTO_INCREMENT,
Nedif INT,
fechaRec DATE,
fechaLim DATE,
CONSTRAINT PK_Recargas PRIMARY KEY(Nrec),
CONSTRAINT FK_Recargas_Edificios FOREIGN KEY(Nedif) REFERENCES Edificios(Nedif)
);

INSERT INTO recargas VALUES
('', 2, '2021-11-24', '2022-11-25'),
('', 1, '2020-10-26', '2021-10-26'),
('', 5, '2019-05-17', '2019-10-17'),
('', 4, '2020-01-04', '2021-12-30'),
('', 3, '2021-08-06', '2022-08-06');

CREATE TABLE Presupuestos(
Npresup INT AUTO_INCREMENT,
idAdm INT,
Nedif INT,
direcEdif VARCHAR(100),
montoPre INT,
fechaPre DATE, 
CONSTRAINT PK_Presupuestos PRIMARY KEY(Npresup),
CONSTRAINT FK_Presupuestos_Administradores FOREIGN KEY(idAdm) REFERENCES Administradores(idAdm),
CONSTRAINT FK_Presupuestos_Edificios FOREIGN KEY(Nedif) REFERENCES Edificios(Nedif)
);

INSERT INTO presupuestos VALUES
('', 3, 1, 'De la amistad 463', 90000, '2020-08-12'),
('', 1, 4, 'LaValle 1547', 10000, '2019-11-05'),
('', 2, 3, 'Balcarce 823', 15400, '2021-06-04'),
('', 5, 2, 'Saavedra 3903', 41000, '2021-08-06'),
('', 4, 5, 'Bruselas 948', 14510, '2019-03-17');

CREATE TABLE Facturas(
Nfact INT AUTO_INCREMENT,
idAdm INT,
Npresup INT,
montoFact INT,
fechaFact DATE,
Abonado BOOLEAN,
CONSTRAINT PK_Facturas PRIMARY KEY(Nfact),
CONSTRAINT FK_Facturas_Administradores FOREIGN KEY(idAdm) REFERENCES Administradores(idAdm),
CONSTRAINT FK_Facturas_Presupuestos FOREIGN KEY(Npresup) REFERENCES Presupuestos(Npresup)
);

INSERT INTO Facturas VALUES
('', 1, 1, 90000, '2020-08-12', FALSE),
('', 2, 3, 10000, '2019-11-05', TRUE),
('', 3, 2, 15400, '2021-06-04', TRUE),
('', 4, 4, 41000, '2021-08-06', FALSE),
('', 5, 5, 14510, '2019-03-17', TRUE);

CREATE TABLE Recibos(
Nreci INT AUTO_INCREMENT,
idAdm INT,
Nedif INT,
Npresup INT,
MontoR INT,
CONSTRAINT PK_Recibos PRIMARY KEY(Nreci),
CONSTRAINT FK_Recibos_Administradores FOREIGN KEY(idAdm) REFERENCES Administradores(idAdm),
CONSTRAINT FK_Recibos_Edificios FOREIGN KEY(Nedif) REFERENCES Edificios(Nedif),
CONSTRAINT FK_Recibos_Presupuestos FOREIGN KEY(Npresup) REFERENCES Presupuestos(Npresup)
);

INSERT INTO Recibos VALUES
('', 1, 4, 2, 10000),
('', 2, 3, 3, 15400),
('', 3, 1, 1, 90000),
('', 4, 5, 5, 14510),
('', 5, 2, 4, 41000);