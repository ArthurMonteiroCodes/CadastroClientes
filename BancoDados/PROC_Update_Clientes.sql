USE Corporativo
GO

CREATE PROCEDURE PROC_Update_Clientes(
	@IdCliente INT,
	@Documento VARCHAR(15),
	@Nome VARCHAR(50),
	@Sexo VARCHAR(1),
	@Email VARCHAR(100),
	@Telefone VARCHAR(11),
	@Fax VARCHAR(11),
	@UF VARCHAR(2)
)

AS

BEGIN

	UPDATE Clientes SET Documento = @Documento, Nome = @Nome, Sexo = @Sexo, Email = @Email, Telefone = @Telefone, Fax = @Fax, UF= @UF WHERE IdCliente = @IdCliente

END