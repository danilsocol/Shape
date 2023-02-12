/* В базе данных MS SQL Server есть продукты и категории.
 * Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
 * Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
 * Если у продукта нет категорий, то его имя все равно должно выводиться.
 */


CREATE TABLE Products (
Id INT PRIMARY KEY,
"Name" TEXT,
);

INSERT INTO Products
VALUES
(1, 'Beef'),
(2, 'Cucumber'),
(3, 'Lemon'),
(4, 'Beef with cucumber'),
(5, 'Water');

CREATE TABLE Categories (
Id INT PRIMARY KEY,
"Name" TEXT
);

INSERT INTO Categories
VALUES
(1, 'Meat'),
(2, 'Vegetables'),
(3, 'Citruses');

CREATE TABLE ProductCategories (
ProductId INT FOREIGN KEY REFERENCES Products(Id),
CategoryId INT FOREIGN KEY REFERENCES Categories(Id)
);

INSERT INTO ProductCategories
VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 1),
(4, 2);



SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductCategories PC
ON P.Id = PC.ProductId
LEFT JOIN Categories C
ON PC.CategoryId = C.Id;
