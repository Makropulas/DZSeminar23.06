Console.Clear();
Console.WriteLine("ВВЕДИТЕ ДВА ЦЕЛЫХ ЧИСЛА И УЗНАЙТЕ, КАКОЕ ИЗ НИХ БОЛЬШЕЕ, А КАКОЕ МЕНЬШЕЕ \n");

Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("------------------------");
Console.WriteLine();

if (number1 > number2)
{
    Console.Write("Большим, является число ");
    Console.WriteLine(number1);
    Console.Write("Меньшим, является число ");
    Console.WriteLine(number2);
}
else
{
    Console.Write("Большим, является число ");
    Console.WriteLine(number2);
    Console.Write("Меньшим, является число ");
    Console.WriteLine(number1);
}


// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.