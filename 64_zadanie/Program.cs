// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine($"Задача 64: Задайте значение N. Напишите программу, которая \nвыведет все натуральные числа в промежутке от N до 1.");
Console.WriteLine();
int n = InputNumbers("Введите n: ");
int count = 2;
Console.WriteLine();
PrintNumber(n, count);
Console.Write(1 + "\n ");

void PrintNumber(int n, int count)
{
    if (count > n) return;
    PrintNumber(n, count + 1);
    Console.Write(count + ", ");
}

int InputNumbers(string input)
{
    Console.Write(input);
    return int.Parse(Console.ReadLine()!);
}