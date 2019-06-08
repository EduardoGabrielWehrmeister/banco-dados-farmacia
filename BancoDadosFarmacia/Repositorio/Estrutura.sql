 DROP TABLE comestiveis
CREATE TABLE comestiveis(
 id INT PRIMARY KEY IDENTITY(1,1),
 nome VARCHAR(100) NOT NULL,
 valor DECIMAL(10,2),
 data_vencimento DATETIME2,
 quantidade INT,
 marca VARCHAR(100),
 );

 DROP TABLE remedios
 CREATE TABLE remedios( 
 id INT PRIMARY KEY IDENTITY(1,1),
 nome VARCHAR(100),
 generico BIT,
 categoria VARCHAR(50),
 solido BIT,
 contra_indicacao VARCHAR(300),
 bula VARCHAR(500),
 faixa VARCHAR(20),
 receita BIT,
 );
