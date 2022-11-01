/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int sum = 0;
int SumBetweenMN(int m, int n)
{
    if (m <= n)
    {
        sum = sum + m;
        SumBetweenMN(m + 1, n);
    }
    return sum;
}

int m = 1;
int n = 15;
int total = SumBetweenMN(m, n);
Console.WriteLine(total);