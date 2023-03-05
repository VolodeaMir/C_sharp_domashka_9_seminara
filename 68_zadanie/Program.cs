// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();
Console.WriteLine($"Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. \nДаны два неотрицательных числа m и n.");
Console.WriteLine();
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

Console.WriteLine();

int functionAkkerman = Akkerman(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman}");

Console.WriteLine();
Console.WriteLine();

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int InputNumbers(string message)
{
    Console.Write(message);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}