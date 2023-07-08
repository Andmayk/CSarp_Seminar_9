// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Readint(string message)
{
    Console.Write(message + " ");
    return Convert.ToInt16(Console.ReadLine());
}

int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akkerman(n - 1, 1);
    if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
    return Akkerman(n, m);
}

///=================================================

int number1 = Readint("Введите число n ");
int number2 = Readint("Введите число m ");

System.Console.WriteLine("Значение функции Аккермана "+Akkerman(number1, number2));
