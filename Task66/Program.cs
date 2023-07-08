// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string message)
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int number1, int number2)
{
    if (number1 > number2) return 0;
    return number1 + SumNumbers(number1 + 1, number2);
}

int number1 = ReadInt("Введите начальное число");
int number2 = ReadInt("Введите конечное число");

if (number1 < number2)
{
    System.Console.WriteLine(SumNumbers(number1, number2));
}
else
{
    System.Console.WriteLine(SumNumbers(number2, number1));
}
