// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.


// 1. Функция по созданию массива из случайных целых чисел (+вывод):
int[] CreateArray(int ArrayLength)
{
    int[] Arr = new int[ArrayLength];
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(1, 101);
        Console.Write($"{Arr[i]} ");
    }
    Console.WriteLine();
    return Arr;
}

// 2. Функция по выводу массива в обратном порядке с исп. рекурсии:
void ReverseAndPrint(int[] Array, int i)
{
    if (i != 0)
    {
        Console.Write($"{Array[i-1]} ");
        ReverseAndPrint(Array, i-1);
    }
}


// 3. Вызов функций и указание длины массива:
int[] Result = CreateArray(10);
ReverseAndPrint(Result, 10);

