/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/


Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if (num >= 10000 && num <= 99999)
{
    string Polindrom(int i)
{
    if (i / 10000 == i % 10 & (i / 1000) % 10 == (i % 100) / 10)
    {
        return "является полиндроном";

    }
    return " не является полидроном";
}
    {
        Console.WriteLine("Число " + Polindrom(num));
    }

}
else
{
    Console.WriteLine(" Error ");
}
