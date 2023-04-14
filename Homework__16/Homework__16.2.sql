--hardware 
/*  1. გამოიტანეთ იმ პროდუქტების სახელწოდება და ღირებულება, რომელთა მწარმოებელი
არის Hewlett-Packard */
select * from [dbo].[Manufacturers]
select * from [dbo].[Products]

select Name, Price from [dbo].[Products] where ManufacturerId=(
select ManufacturerID from [dbo].[Manufacturers] where Name = 'Hewlett-Packard')

/*2. გამოიტანეთ იმ პროდუქტების სახელწოდება და ღირებულება, რომლებიც არ უწარმოებია
Fujitsu -ს*/
select Name, Price from [dbo].[Products] where ManufacturerId not in(
select ManufacturerID from [dbo].[Manufacturers] where Name = 'Fujitsu')

/*3. გამოიტანეთ იმ პროდუქტების სახელწოდება და ღირებულება, რომელთა მწარმოებელი
არის Sony, Fujitsu, IBM ან IBM  */
select Name, Price from [dbo].[Products] where manufacturerId in(
select manufacturerId from [dbo].[Manufacturers] where Name in ('Sony','Fujitsu','IBM'))

/* 4. გამოიტანეთ იმ კომპანიების სახელწოდებები, რომლებმაც აწარმოეს 200 -ზე უფრო მაღალი
ღირებულების მქონე პროდუქტები */
select Name from [dbo].[Manufacturers] where ManufacturerId in(
select ManufacturerId from[dbo].[Products]where Price>200)

/* 5. გამოიტანეთ იმ პროდუქტების სახელწოდება და ღირებულება, რომლებსაც არ აწარმოებს Genius და Dell */

select name, Price from[dbo].[Products] where ManufacturerId not in (
select ManufacturerId from [dbo].[Manufacturers] where Name  not in ('Genius','Dell'))

/* 6. გამოიტანეთ იმ მწარმოებელთა რაოდენობა, რომლებიც აწარმოებენ drive -ებს */
select count(manufacturerId) from [dbo].[Manufacturers] where manufacturerId in(
select manufacturerId from [dbo].[Products]where name like '%drive')

/* 7. გამოიტანეთ Intel -ის მიერ წარმოებული იმ პროდუქტების რაოდენობა, რომელთა ფასი აღემატება Intel -ის მიერ
წარმოებული პროდუქტების საშუალო ფასს.*/

select Count(Price) from[dbo].[Products] p
join [dbo].[Manufacturers] m on p.ManufacturerId=m.ManufacturerId
where m.Name ='Intel' and p.Price>(
select avg(Price) from[dbo].[Products] where ManufacturerId in
(select ManufacturerId from [dbo].[Manufacturers] where Name='Intel'))

