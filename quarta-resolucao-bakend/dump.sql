-- Script para criar banco e tabelas no SQLSever --

CREATE DATABASE CadastroClientes;
GO

USE CadastroClientes;
GO

CREATE TABLE Estado (
    id_estado INT IDENTITY(1,1) PRIMARY KEY,
    sigla CHAR(2) NOT NULL UNIQUE,
    nome VARCHAR(50) NOT NULL,
);
GO

CREATE TABLE Clientes (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    razao_social VARCHAR(100) NOT NULL,
    estado_id INT NOT NULL,
    FOREIGN KEY (estado_id) REFERENCES Estado(id_estado)
);
GO

CREATE TABLE Tipos_Telefone (
    id_tipo_telefone INT IDENTITY(1,1) PRIMARY KEY,
    tipo VARCHAR(50) NOT NULL
);
GO

CREATE TABLE Telefone (
    id_telefone INT IDENTITY(1,1) PRIMARY KEY,
    numero VARCHAR(15) NOT NULL,
    cliente_id INT NOT NULL,
    tipo_telefone_id INT NOT NULL,
    FOREIGN KEY (tipo_telefone_id) REFERENCES Tipos_Telefone(id_tipo_telefone),
    FOREIGN KEY (cliente_id) REFERENCES Clientes(id_cliente)
);
GO