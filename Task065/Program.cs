// **Задача 65:**Задайте значения M и N.
//  Напишите программу, которая выведет все
//   натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

Console.Clear();

Console.Write("Введите число M: ");
long M = long.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
long N = long.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(M, N));

string PrintNumbers(long numberOne, long numberTwo)
{
    if (numberTwo == numberOne)
    {
        Console.WriteLine(numberTwo);
        return numberTwo.ToString();
    }
    string range = PrintNumbers(numberOne, numberTwo - 1) + ' ' + numberTwo.ToString();
    Console.WriteLine(range);
    return (range);
}
