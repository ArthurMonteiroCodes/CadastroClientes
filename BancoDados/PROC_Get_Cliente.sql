use Corporativo
GO

CREATE PROCEDURE PROC_Get_Cliente
(
@IdCliente INT
)
AS

SELECT IdCliente, Documento, Nome, Sexo, Email, Telefone, Fax, UF FROM Clientes WHERE IdCliente = @IdCliente 