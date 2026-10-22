USE Corporativo
GO

CREATE PROCEDURE PROC_Listar_Clientes

AS

SELECT IdCliente, Documento, Nome, Sexo, Email, Telefone, Fax, UF FROM Clientes