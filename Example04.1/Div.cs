// Программа, которая принимает на вход два рандомных числа и делит одно число на другое.

double number1 = new Random().Next(1, 10000);
Console.WriteLine($"Первое число: {number1}");

double number2 = new Random().Next(1, 10000);
Console.WriteLine($"Второе число: {number2}");

Console.WriteLine($"Частное двух случайных чисел:{(number1) / (number2)}");
