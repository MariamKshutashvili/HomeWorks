/* TSQL 2012 Join*/
/*1. გამოიტანეთ ლონდონელი და მადრიდელი კლიენტების გვარი, სახელი, ქალაქი და შეკვეთების თარიღები */

select * from  Sales.Orders
select contactname, city,orderdate from [Sales].[Customers]SC 
join Sales.Orders SO on SO.custid=SC.custid 
where SC.city in ('London','Madrid')

/* გამოიტანეთ იმ პროდუქტების სახელწოდება ზედა რეგისტრში, ფასი და კატეგორია, რომელთა ფასი 20-დან
40-მდეა*/
--ზედა რეგისტრი upper case?

select categoryname,productname,unitprice from [Production].[Products] pp 
join [Production].[Categories] pc on pp.categoryid=pc.categoryid
where pp.unitprice between 20 and 40

/*3. გამოიტანეთ გაყიდვების მენეჯერების გვარი, სახელი და შეკვეთების იდენტიფიკატორი (orderid), რომელსაც
Sales Manager მოემსახურნენ. გამოიტანეთ მხოლოდ 50 -ზე მეტი წონის შეკვეთები */

select title, freight,firstname, lastname, orderid  from [HR].[Employees] he
join [Sales].[Orders] so on he.empid=so.empid
where freight > 50 and  title = 'Sales Manager'

/*4. გამოიტანეთ შეკვეთის თარიღი, კლიენტის გვარი, სახელი, ქალაქი და მისამართი იმ შეკვეთებისათვის,
რომლებიც გაკეთდა 2007 წელს ამერიკული კომპანიის მიერ */

select contactname, city,orderdate,shipaddress from [Sales].[Customers]SC 
join Sales.Orders SO on SO.custid=SC.custid 
where year(orderdate)>=2007 and shipcountry ='USA'

/* 5. გამოიტანეთ იმ ქალაქების სახელები, სადაც მოხდა კომპანიის თანამშრომელ Cameron -ის მიღებული
შეკვეთების ტრანსპორტირება. მიღებულ ვირტუალურ ცხრილში ქალაქების სახელები არ განმეორდეს */

select DISTINCT  shipcity from [HR].[Employees] he
join [Sales].[Orders] so on he.empid=so.empid
where lastname=	'Cameron'
select* from [HR].[Employees]

/*  6. გამოიტანეთ გადამზიდავი კომპანიების მიერ გერმანიაში და ავსტრიაში ტრანსპორტირებული შეკვეთების id
(orderid), ასევე ქვეყანა და ქალაქი, სადაც მოხდა შეკვეთის ტრანსპორტირება */

select companyname, shipcity, shipcountry, so.orderid from [Production].[Suppliers] ps
join [Production].[Products] pp on ps.supplierid=pp.supplierid
join [Sales].[OrderDetails] sod on pp.productid=sod.productid
join [Sales].[Orders] so on sod.orderid=so.orderid
where shipcountry in ('Germany','Austria')

/* 7. გამოიტანეთ სრული მონაცემები ტოკიოდან (Tokyo) მოწოდებული იმ პროდუქტების შესახებ, რომლებზეც
მოქმედებს ფასდაკლება */
select * from  [Production].[Products] pp 
join [Production].[Suppliers] ps on pp.supplierid=ps.supplierid
where ps.city='Tokyo' and discontinued=1


/* 8. გამოიტანეთ იაპონიიდან მოწოდებული ზღვის პროდუქტების და სასმელების დასახელებები კატეგორიის
სახელწოდებებთან ერთად */
select categoryname,description from  [Production].[Products] pp 
join [Production].[Suppliers] ps on pp.supplierid=ps.supplierid
join [Production].[Categories] pc on pp.categoryid=pc.categoryid
where ps.country='Japan' and categoryname in('Seafood', 'Beverages')

/* 9. გამოიტანეთ კომპანიის თანამშრომლების სახელი და გვარი და გადამზიდავი კომპანიების სახელწოდებები,
რომლებმაც 2007 წელს გადაზიდეს შეკვეთები, რომლებსაც მოემსახურნენ სარა დევისი (Sara Davis) და მარია
ქემერონი (Maria Cameron) */

select companyname, contactname, firstname, lastname from [Production].[Suppliers] ps
join [Production].[Products] pp on ps.supplierid=pp.supplierid
join [Sales].[OrderDetails] sod on pp.productid=sod.productid
join [Sales].[Orders] so on sod.orderid=so.orderid
join [HR].[Employees] hr on hr.empid=so.empid
where  year(shippeddate)=2007 and ((firstname='Sara'and lastname='Davis') 
or (firstname='Maria'and lastname='Cameron'))


select * from [Production].[Categories]
select * from [Production].[Suppliers] 
select* from [Sales].[Orders]
select * from [HR].[Employees]
/* 10. გამოიტანეთ ამერიკელი მწარმოებლების მიერ წარმოებული იმ პროდუქტების სახელწოდებები და კატეგორიები,
რომლებიც არ მიეკუთვნება ზღვის პროდუქტების და წვენების კატეგორიას */

select categoryname,description from  [Production].[Products] pp 
join [Production].[Suppliers] ps on pp.supplierid=ps.supplierid
join [Production].[Categories] pc on pp.categoryid=pc.categoryid
where ps.country='USA' and categoryname not in('Seafood', 'Beverages')


/* 11. გამოიტანეთ შეკვეთის ნომერი, კომპანიის თანამშრომლის გვარი, სახელი და საცხოვრებელი ქალაქი, კლიენტის
სახელი და გვარი იმ შეკვეთებისათვის, რომლის კლიენტი და კომპანიის თანამშრომელი ცხოვრობენ ერთ
ქალაქში*/
select orderid,lastname,firstname, hr.city,contactname,sc.city from [Sales].[Customers] sc
join [Sales].[Orders] so on sc.custid=so.custid		
join [HR].[Employees] hr on hr.empid=so.empid
where sc.city=hr.city


/*12. გამოიტანეთ იმ კლიენტების სახელი და გვარი, რომლებმაც შეუკვეთეს სასმელები (Beverages) ან რძის
პროდუქტები (Dairy Products). ერთი და იგივე კლიენტის სახელი და გვარი გამოიტანეთ მხოლოდ ერთხელ.*/
select distinct contactname from  [Production].[Products] pp 
join [Production].[Categories] pc on pp.categoryid=pc.categoryid
join [Sales].[OrderDetails] sod on pp.productid=sod.productid
join [Sales].[Orders] so on sod.orderid=so.orderid
join [Sales].[Customers] sc on sc.custid=so.custid		
where categoryname in ('Beverages', 'Dairy Products')
