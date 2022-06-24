Console.Clear();

Console.WriteLine("Введите целое число, а я проверю, является ли оно чётным :)");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (number%2 == 0)
{
    Console.Write("Введённое вами число является чётным");
}
else
{
    Console.Write("Введённое вами число является нечётным");
}


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
