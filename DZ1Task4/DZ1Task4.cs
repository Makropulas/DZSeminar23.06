Console.Clear();
Console.WriteLine("ВВЕДИТЕ ТРИ ЦЕЛЫХ ЧИСЛА И УЗНАЙТЕ, КАКОЕ ИЗ НИХ ЯВЛЯЕТСЯ МАКСИМАЛЬНЫМ \n");

Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

Console.WriteLine();
Console.WriteLine("------------------------");
Console.WriteLine();

if (number2 > number1) max = number2;
if (number3 > number2) max = number3;

Console.Write("Из заданных трёх чисел, максимальным является число ");
Console.WriteLine(max);

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
