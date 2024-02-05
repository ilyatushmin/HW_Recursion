// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.



// 1. Задать глобальные переменные :)
int M = 3;
int N = 2;


// 2. Составить функцию с рекурсией.
int Akkerman(int num1, int num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }

    if (num2 == 0)
    {
        return Akkerman(num1 - 1, 1);
    }

    return Akkerman(num1 - 1, Akkerman(num1, num2 - 1));
}

// 3. Вывод результата:
Console.Write(Akkerman(M, N));