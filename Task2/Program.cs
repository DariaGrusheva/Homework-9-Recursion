// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumbersSumm(int m, int n)
{
    if (m <= n)
        return m + NumbersSumm(m + 1, n);
    else return 0;
}

bool Check(int m, int n)
{
    if (m < 1 || n < 1)
    {
        Console.WriteLine("Вы ввели не натуральные числа. Программа будет завершена. Попоробуйте снова.");
        return false;
    }
    else if (m > n)
    {
        Console.WriteLine("Число m должно быть меньше числа n. Программа будет завершена. Попоробуйте снова.");
        return false;
    }
    else if (m == n)
    {
        Console.WriteLine("0");
        return false;
    }
    else
        return true;
}


Console.WriteLine("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (Check(m, n))
{
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна: ");
    Console.WriteLine(NumbersSumm(m, n));
}
else
{
    Console.ReadLine();
    System.Environment.Exit(0);
}
