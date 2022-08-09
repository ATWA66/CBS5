//task4
double bonus;
double salary;
int exp;
Console.WriteLine("Enter salary:");
salary = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter experiance:");
exp = Convert.ToInt32(Console.ReadLine());
if (exp < 5 && exp >= 0)
{
    bonus = 10;
    salary += (salary*(bonus / 100));
}
else if (exp < 10 && exp >= 5)
{
    bonus = 15;
    salary += (salary * (bonus / 100));
}
else if (exp < 15 && exp >= 10)
{
    bonus = 25;
    salary += (salary * (bonus / 100));
}
else if (exp < 20 && exp >= 15)
{
    bonus = 35;
    salary += (salary * (bonus / 100));
}else if (exp < 25 && exp >= 20)
{
    bonus = 45;
    salary += (salary * (bonus / 100));
}
else if (exp >= 25)
{
    bonus = 50;
    salary += (salary * (bonus / 100));
}
else
{
    Console.WriteLine("An error occured");
}
Console.WriteLine("Salary with bonus:"+ salary);