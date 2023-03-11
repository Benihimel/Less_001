// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int C = number % 2; 
if (C == 0)
{
    Console.WriteLine("Yes, this is an even number");
}
else
{
    Console.WriteLine("No, this is an odd number");
}

