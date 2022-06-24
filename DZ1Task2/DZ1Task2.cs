class Program
{
    // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("ВВЕДИТЕ ДВА ЦЕЛЫХ ЧИСЛА И УЗНАЙТЕ, КАКОЕ ИЗ НИХ БОЛЬШЕЕ, А КАКОЕ МЕНЬШЕЕ \n");

        Console.Write("Введите первое число ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("------------------------ \n");

        if (number1 > number2)
        {
            Console.WriteLine($"Большим, является число {number1}");
            Console.WriteLine($"Меньшим, является число {number2}");
        }
        else
        {
            Console.WriteLine($"Большим, является число {number2}");
            Console.WriteLine($"Меньшим, является число {number1}");
        }
    }
}