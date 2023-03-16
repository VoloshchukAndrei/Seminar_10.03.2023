/***Задача 67:**Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

Console.Clear();

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine($"{M} -> {PrintSumNumbers(M)}");

// int PrintSumNumbers(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     return sum;
// }


int PrintSumNumbers(int number)
{
    if (number == 0)
    {
        return (0);
    }
    else
    {
        return (number % 10 + PrintSumNumbers(number / 10));
    }
}