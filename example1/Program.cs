// Тема 1: Двумерные массивы.
//Пример задачи на двумерный массив:

//Задайте двумерный массив, заполненный случайными целыми числами.
// m=3, n=4
// -1 3 8 9
// 2 -5 8 2
// 3 4 7 -7

int [,] array = CreateRandom2dArray(3, 4);
Print2DArray(array);

int [,] CreateRandom2dArray(int countOfRows, int countOfColumns)
{
    Random random = new Random();
    int[,] array = new int[countOfRows, countOfColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(-10, 11);
        }
    }
    return array;
}

void Print2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

// Тема 2: Кортежи. 
// Пример:
Console.WriteLine();
Console.WriteLine("демонстрация кортежа:"); // для отделения от предыдыщей темы в выводе рез-та

(int, int, string) coordinates = GetSomething();
Console.WriteLine(coordinates.Item1); //возвращает a
Console.WriteLine(coordinates.Item2); //возвращает b
Console.WriteLine(coordinates.Item3); //возвращает c

(int, int, string) GetSomething()
{
    int a = 5;
    int b = 10;
    string c = "это был пример кортежа";
    return (a,b,c);
}
