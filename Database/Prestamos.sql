create database PrestamosDB
use PrestamosDB

--creando tablas--
Create table Clientes(
IdCliente int Primary key,
NombreCompleto varchar,
Correo varchar,
Telefono varchar,
Direccion varchar,
Sueldo decimal,
Garantia varchar,
);
select * from Clientes

CREATE TABLE Prestamos (
    IdPrestamo INT IDENTITY(1,1) PRIMARY KEY,
    IdCliente INT,
    Monto DECIMAL(12,2),
    Meses INT,
    Interes DECIMAL(10,2),
    TotalPagar DECIMAL(12,2),
    FechaPrestamo DATE,

    CONSTRAINT FK_Prestamo_Cliente
    FOREIGN KEY (IdCliente)
    REFERENCES Clientes(IdCliente)
);
select * from Prestamos

CREATE TABLE Pagos (
    IdPago INT IDENTITY(1,1) PRIMARY KEY,
    IdPrestamo INT,
    MontoAnterior DECIMAL(12,2),
    InteresPago DECIMAL(10,2),
    Cuota DECIMAL(10,2),
    NuevoSaldo DECIMAL(12,2),
    MesesRestantes INT,

    CONSTRAINT FK_Pago_Prestamo
    FOREIGN KEY (IdPrestamo)
    REFERENCES Prestamos(IdPrestamo)
);


CREATE TABLE Moras (
    IdMora INT IDENTITY(1,1) PRIMARY KEY,
    IdPrestamo INT,
    MontoMora DECIMAL(10,2),
    FechaMora DATE,

    CONSTRAINT FK_Mora_Prestamo
    FOREIGN KEY (IdPrestamo)
    REFERENCES Prestamos(IdPrestamo)
);

