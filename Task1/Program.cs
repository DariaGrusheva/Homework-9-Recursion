// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью


string Nambers(int n)
{
    if (n >= 1) return $"{n}" + "\t" + Nambers(n - 1);
    else
    {
        Console.Write("Вы ввели не натуральное число. Программа завершит свою работу. Попробуйте снова.");
        Console.ReadLine();
        return String.Empty;
    }
}


Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(Nambers(n));