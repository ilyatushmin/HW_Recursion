// Задача 1: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.



// 1. Задать глобальные переменные :)
int M = 2;
int N = 9;


// 2. Составить функцию с рекурсией. Включая условие, если M>N или если N>M.
string GetNumsFromMtoN(int num1, int num2)
{
    if (num1 > num2)
    {
        if (num1 == num2)
        {
            return num2.ToString();
        }
        return num1.ToString() + ", " + GetNumsFromMtoN(num1 - 1, num2);
    }
    else
    {
        if (num2 == num1)
        {
            return num1.ToString();
        }
        return num2.ToString() + ", " + GetNumsFromMtoN(num1, num2 - 1);
    }

}

// 3. Вывод результата:
Console.WriteLine(GetNumsFromMtoN(M, N));