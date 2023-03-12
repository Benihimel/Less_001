// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
//  -> 2, 4, 6, 8

Console.Write("Input number N: ");
int number = Convert.ToInt32(Console.ReadLine());

int C = 2;

if(number > 1)
{
    while(C <= number)
    {
        Console.Write(C + " ");
        C += 2;
    }
}
