// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

int num = new Random().Next(10000, 100000);
int rev = 0;

while (num > 0)
{
    int lost = num % 10;
    rev= (rev * 10) + lost;
    num = num / 10;
}
if (num == rev)
{
    System.Console.WriteLine($"{rev} = палиндром!");
}
else
{
    System.Console.WriteLine($"{rev} = НЕ палиндром!");
}