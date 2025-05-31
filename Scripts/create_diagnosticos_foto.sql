-- Script para crear la tabla DiagnosticosFoto
CREATE TABLE DiagnosticosFoto (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    BovinoId INT NOT NULL,
    Fecha DATETIME2 NOT NULL DEFAULT GETDATE(),
    Imagen VARBINARY(MAX),
    AnalisisHF NVARCHAR(MAX),
    Enfermedades NVARCHAR(MAX),
    Causas NVARCHAR(MAX),
    Tratamientos NVARCHAR(MAX)
);
