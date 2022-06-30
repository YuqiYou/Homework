/*question 1*/
SELECT ProductID,Name,Color,ListPrice
FROM Production.Product

/*question 2*/
SELECT ProductID,Name,Color,ListPrice
FROM Production.Product
WHERE ListPrice!=0

/*question 3*/
SELECT ProductID,Name,Color,ListPrice
FROM Production.Product
WHERE Color IS NOT NULL

/*question 4*/
SELECT ProductID,Name,Color,ListPrice
FROM Production.Product
WHERE Color IS NOT NULL AND ListPrice > 0

/*question 5*/
SELECT Name + ' ' + Color
FROM Production.product
WHERE Color IS NOT NULL

/*question 6*/
SELECT TOP 6 'NAME: ' + Name + ' -- COLOR: ' + Color  
FROM Production.product
WHERE Color IS NOT NULL


/*question 7*/
SELECT ProductID,Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500

/*question 8*/
SELECT ProductID,Name,Color
FROM Production.Product
WHERE Color IN ('black', 'blue')

/*question 9*/
SELECT Name, ProductID
FROM Production.Product
WHERE NAME like 'S%'

/*question 10*/
SELECT TOP 5 Name,ListPrice
FROM Production.Product
WHERE NAME like 'A%' OR NAME like 'S%'
ORDER BY NAME


/*question 11*/
SELECT Name
FROM Production.Product
WHERE Name LIKE 'SPO%' AND Name NOT LIKE '___K%'
ORDER BY Name

/*question 12*/
SELECT DISTINCT IsNULL(ProductSubcategoryID,'') As ProductSubcategoryID, IsNuLL(Color,'') AS Color
FROM Production.Product