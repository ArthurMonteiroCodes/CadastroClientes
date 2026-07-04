use Corporativo

--INSERT CLIENTES PARA TESTE
INSERT INTO Clientes VALUES (1, '1234567899', 'Cliente Teste 1', 'M', 'cliente@gmail.com', '1123456789', '11888888', 'SP')
INSERT INTO Clientes VALUES (2, '9987654321', 'Cliente Teste 2', 'S', 'cliente@icloud.com', '114567892', '11999999', 'SC')

--UPDATE CLIENTES PARA TESTE 
UPDATE Clientes SET Nome = 'Cliente Teste 3' WHERE IdCliente = 2

--SELECT CLIENTES
SELECT * FROM clientes

--DELETAR DADOS
DELETE FROM Clientes WHERE Idcliente = 2