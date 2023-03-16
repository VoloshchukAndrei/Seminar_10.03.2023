// **Задача 69:**Напишите программу,
//  которая на вход принимает два числа A и B,
//   и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)

// A = 2; B = 3-> 8

Console.Clear();

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

Console.Write(NaturalDegree(numberA, numberB));
// Console.Write($"Число A в натуральной степень числа B: {NaturalDegree(numberA, numberB)}");

int NaturalDegree(int N, int M)
{
    if (M == 0)
    {
        return 1;
    }
    return (N * NaturalDegree(N, M - 1));
}