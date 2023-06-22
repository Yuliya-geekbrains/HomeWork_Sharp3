// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
string num1 = Convert.ToString(num);

if(num1.Length == 5)
{
    if(num1[0] == num1[4] && num1[1] == num1[3])
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else Console.WriteLine($"Число {num} не является палиндромом");
}
else Console.WriteLine($"Число {num} не является пятизначным");
