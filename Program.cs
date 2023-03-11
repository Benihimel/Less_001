// Задача 2: Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, 
//а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Input number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Number 1 is max = {number1}. Number 2 is min = {number2}.");
}
else
{
    if (number1 < number2)
    {
        Console.WriteLine($"Number 2 is max = {number2}. Number 1 is min = {number1}.git");
    }
        if (number1 == number2)
        {
            Console.WriteLine($"Number 1 = Number 2.");
        }
        
}      








