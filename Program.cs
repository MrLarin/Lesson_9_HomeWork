/* Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

Print(N, 1);

void Print(int _n, int _m)
{
    if (_n != _m)
    {
        Console.Write($"{_n}, ");
        Print(_n - 1, _m);
    }
    else
        Console.Write($"{_m}, ");
}


/* Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15-> 120
M = 4; N = 8. -> 30
*/

int N;
Console.Write($"Введите число от: ");
int.TryParse(Console.ReadLine()!, out N);
int M;
Console.Write($"Введите число до: ");
int.TryParse(Console.ReadLine()!, out M);

Console.Write($"Сумма цифр от {N} до {M}: {Total(N, M)} \n");

int Total(int _n, int _m)
{
    if (_n <= _m)
        return _n += Total(_n + 1, _m);
    else return 0;
}


/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29
*/
int m;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out m);
int n;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out n);

Console.Write($"{A(m, n)} \n");

int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}
