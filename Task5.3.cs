/*
Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] CreateNumbersArray()
{
    Console.Write("Введите кол-во чисел для массива > ");
    int len = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100, 2);
    }
    return array;
}


void PrintArray(double[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "   ");
    }
    Console.WriteLine();
}


double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}


double[] numbersArray = CreateNumbersArray();
PrintArray(numbersArray, "Массив:");
System.Console.Write("Разница между макс и мин элементом массива -> ");
System.Console.Write(Math.Round(Max(numbersArray) - Min(numbersArray), 2));