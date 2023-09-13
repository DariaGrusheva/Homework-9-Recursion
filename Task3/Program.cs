// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Accremanes(int m, int n)
{
    if (m == 0 && n > 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Accremanes(m - 1, 1);
    else
        return Accremanes(m - 1, Accremanes(m, n - 1));
}

bool Check(int m, int n)
{
    if (m > 0 && m < 4 && n > 0) return true;
    else if (m > 3)
    {
        Console.WriteLine("Вы все сделали верно, но количество цифр значения функции Аккермана многократно превосходит количество атомов в наблюдаемой части вселенной.");
        return false;
    }
    else
    {
        Console.WriteLine("Не все введенные Вами числа являются положительными. Программа будет завершена. Попоробуйте снова.");
        return false;
    }
}

Console.WriteLine("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (!Check(m, n))
{

    Console.ReadLine();
    System.Environment.Exit(0);
}
else
{
    Console.WriteLine("Значение функции Аккермана равно: ");
    Console.WriteLine(Accremanes(m, n));
}