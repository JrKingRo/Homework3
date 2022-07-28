/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
*/

Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    {
        Console.WriteLine($"{i}*{i}*{i} ={i*i*i}");
    }
}






