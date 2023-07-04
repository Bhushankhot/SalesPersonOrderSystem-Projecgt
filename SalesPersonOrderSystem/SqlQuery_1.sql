CREATE TABLE SalesPerson (
  ID INT PRIMARY KEY,
  Name VARCHAR(50) NOT NULL
);


INSERT INTO SalesPerson (ID, Name)
VALUES
  (1, 'Abe'),
  (2, 'Bob'),
  (3, 'Chris'),
  (4, 'Dan'),
  (5, 'Ken'),
  (6, 'Joe');

select * from SalesPerson

CREATE TABLE Customers (
  ID INT PRIMARY KEY,
  Name VARCHAR(50) NOT NULL
);

INSERT INTO Customers (ID, Name)
VALUES
  (1001, 'Samsonic'),
  (1002, 'Panasung'),
  (1003, 'Samony'),
  (1004, 'Orange');

select * from Customers;

CREATE TABLE Orders (
  Order_id INT PRIMARY KEY IDENTITY(1,1),
  order_date DateTime NOT NULL,
  Amount INT NOT NULL,
  cust_id INT FOREIGN KEY REFERENCES Customers(ID),
  salesperson_id INT FOREIGN KEY REFERENCES SalesPerson(ID)
);


select * from Orders


select ID from SalesPerson where Name='Dan'

select * from Orders where salesperson_id=(select ID from SalesPerson where Name='Dan')