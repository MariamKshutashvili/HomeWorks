--Students

--1. გამოიტანეთ ყველა სტუდენტი რომელიც დაიბადა 1990 წლის შემდეგ
select * from Students

select * from [dbo].[Students] where DoB > '1990-01-01'

/*2. გამოიტანეთ იმ სტუდენთა სახელი გვარი ასაკი(CurrentYear- DoB) რომლებიც არიან
საქართველოდან და ლიბიიდან */

alter table Students add Age as (Year(GetDate())-Year(DoB))
select Firstname, Lastname, Age, Country from Students where Country in ('Libya','Georgia')

	
/*3. დაამატეთ ახალი სტუდენტი მონაცემთა ბაზაში ნებისმიერი მონაცემებით*/
Insert into Students (Lastname,[Firstname],[DoB],[Email],[Quiz1],[Quiz2],[MiddleTest],[FinalTest],[Country])
Output inserted.*
values ('Tetvadze','Lizi','1989-09-23','Ltetv20@freeuni.edu.ge',2,3,28,30,'Georgia')


/*4. გამოიტანეთ TOP 5 შედეგის მქონე სტუდენტის სახელი და ქულა შუალედურზე ([MiddleTest])
მიღებული ქულის მიხედვით (აჩვენეთ ყველა შესაძლო ვარიანტი მაგ : 1 2 3 4 5 5 თუ მომდევნო
ელემენტიც 5 ტოლია შედეგი უნდა იყოს 1,2,3,4,5,5 */

select top 5 with ties * from Students order by MiddleTest desc

/*5. წაშალეთ ყველა სტუდენტი რომლებმაც ფინალურზე 19 ქულა მიიღეს და შედეგი გამოიტანეთ
OUTPUT სახით*/
delete Students  
output deleted.Firstname, deleted.Lastname
where FinalTest=19

/* 6. განაახლეთ მონაცემები ყველა სტუდენტს რომელსაც შუალედურზე აქვს მიღებული 1 ქულა
ფინალურ შეფასებაში ჩაუწერეთ 0 */
update Students
set FinalTest=0
output inserted.Firstname, inserted.Lastname
where MiddleTest=1

--Persons!!!!!!!!!!!!!!!!!!!!!
/*1. გამოიტანეთ სრული მონაცემები იმ პირების შესახებ რომელთა პირადი ნომერიPrivateId იწყება 163*/select * from Persons select * from Persons where PrivateId  like '163%'/* 2. გამოიტანეთ სრული მონაცემები იმ პირების რომელთა გვარი ემთხვევა იმ ქალაქის
სახელწოდებას სადაც ცხოვრობენ*/select * from Persons where Lastname=City/* 3. გამოიტანეთ სრული მონაცემები იმ პირების შესახებ რომლებიც ცხოვრობენ კანადაში ან
მონაკოში არ გამოიყენოთ ტოლობა და Like ოპერატორი*/select * from Persons where Country in ('Canada','Monaco')/* 4. გამოიტანეთ იმ პირების სახელი ,გვარი და პირადი ნომერი რომლებსაც არ აქვთ იმეილი. */
select Firstname,Lastname, PrivateId, Email from Persons where Email is Null

/*5. გამოიტანეთ სრული მონაცემები იმ პირების შესახებ რომლებიც ცხოვრობენ ესპანეთში ან
თურქეთში და ხელფასი არის 1000-3000 დიაპაზონში ( არ გამოიყენოთ მეტობა/ნაკლებობის
ნიშნები)*/

select * from Persons where Country in('Spain','Turkey') and Salary between 1000 and 3000

/* 6. გამოიტანეთ კომპანიების სახელწოდება რომლებიც შეიცავენ LLC, PC , LLP*/
select * from Persons 
select WorkPlace from Persons where WorkPlace like '%LLC%' or WorkPlace like '%PC%' or WorkPlace like '%LLP%'


/* 7. შეამოწმეთ რამდენი წერტილს შეიცავს მეილი თუ წერტილების რაოდენობა მეტია 2 ზე ახალ
ველში MAILINFO გამოიტანეთ 'more than 2 dots ' თუ ნაკლები 'less than 2 dots'*/

alter table Persons add dots as len(Email) - len(replace(Email,'.','')) 
select Firstname,Lastname,Email,dots,
Case
	when dots > 2 then 'more than 2 dots'
	when dots < 2 then 'less than 2 dots'
	when dots is null then 'null'
	else '2 dots'
end as Mailinfo
	from Persons;
	
/* 8. გამოიტანეთ სრული მონაცემები იმ პირების შესახებ რომელთა პინ კოდიც მთავრდება 51 */
select * from Persons where PINcode like '%51'

/* 9. დააჯგუფეთ ცხრილი ქვეყნების მიხედვით და გამოიტანეს საშუალო ხელფასი ქვეყნების მიხედვით */
select Country, avg(Salary) as Average_Salary from Persons
group by Country