// Программа, которая принимает на вход два натуральных числа и суммирует их.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 + number2;

Console.Write($"Сумма = {result}");
