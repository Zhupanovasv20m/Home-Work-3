// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
System.Console.WriteLine("Введите любое число");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<= n; i++)
{
    System.Console.Write($"{Math.Pow(i, 3)}, ");
}