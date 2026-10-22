USE Corporativo
go

CREATE PROCEDURE PROC_Deletar_Clientes 
(
	@IdCliente INT
)

AS

BEGIN

	DELETE FROM Clientes WHERE IdCliente = @IdCliente

END