--select kodu seçmeye yarar, * ise her türlü kolonu getir demek
select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers  -- bu verileri sahte bir tabloyla döndürür

select * from Customers where City = 'London'  -- koşul

select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 and UnitPrice > 10

select * from Products order by ProductName

select * from Products order by CategoryID, ProductName  -- önce kategori Id'ye göre, sonra her kategoriyi kendi içinde isme göre listeler
-- default olarak asc (ascending - artan), değiştirmek için desc (descending - düşen)

select * from Products where CategoryID = 1 order by UnitPrice desc

select count(*) UrunSayisi from Products -- satır sayısını döndürür

select CategoryID, count(*) from Products group by CategoryID  -- group by tekrarlamayacak şekilde verileri getirir
-- count, her kategori id için ayrı grup oluşturulduğu için her kategorinin sayısını verir

select CategoryID, count(*) from Products group by CategoryID having count(*) < 10 -- kümülatif data için having kullanılır

select CategoryID, count(*) from Products where UnitPrice > 20 group by CategoryID having count(*) < 10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID  -- DTO --> Data Transformation Object

select * from Products p left join [Order Details] od  -- solda olup sağda olmayanları da getir
on p.ProductID = od.ProductID

select * from Customers c left join Orders o  -- solda olup sağda olmayanları da getir, mesela hiç sipariş vermeyen müşteriler
on c.CustomerID = o.CustomerID
where o.CustomerID is null

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o 
on o.OrderID = od.OrderID