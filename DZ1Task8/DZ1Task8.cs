class Program
{
    // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int x = 2;
        int zero = 0;
        int one = 1;

        Console.WriteLine();
        Console.WriteLine("От единицы до вашего числа имеются такие чётные числа: \n");

        if (number <= zero)
        {
            Console.WriteLine("Число не соответствует условиям этой задачи");
        }
        if (number == one)
        {
            Console.WriteLine("Нет чётных чисел");
        }
        while (x <= number)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine(x);
            }
            x++;
        }
    }
}