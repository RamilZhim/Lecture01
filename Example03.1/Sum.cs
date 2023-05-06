// Программа, которая принимает на вход два натуральных рандомных числа и суммирует их.

int number1 = new Random().Next(1, 1000);
Console.WriteLine($"Первое число {number1}");

int number2 = new Random().Next(1, 1000);
Console.WriteLine($"Второе число {number2}");

Console.WriteLine($"Сумма чисел будет равняться: {(number1 + number2)}");