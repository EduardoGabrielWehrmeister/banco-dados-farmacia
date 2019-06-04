CREATE TABLE comestiveis(
 id INT PRIMARY KEY IDENTITY(1,1),
 nome VARCHAR(50),
 valor DECIMAL(10,2),
 data_vencimento DATETIME2,
 quantidade INT,
 marca VARCHAR(100),
 );