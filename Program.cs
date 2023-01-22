// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();

int [] generateArray (int lenght, int start, int end)
{
    int [] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(start, end +1);
    }
    return result;
}

void printArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("[");
    Console.ResetColor();
    for (int i = 0; i < array.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write(array[i]);
        Console.ResetColor();
        if (i < array.Length - 1)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(", ");
            Console.ResetColor();
        }
    }
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("]");
    Console.ResetColor();
}

int getCountEven(int[] array)
{
    int count = 0;
     for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] Array = generateArray(8, 100, 999);
printArray(Array);
int count = getCountEven(Array);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Количество чётных чисел в массиве - {count}");
Console.ResetColor();
