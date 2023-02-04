int[,] GenerateRandomArray(int rows, int columns)
{
    Random random = new Random();
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }
    return array;
}
void PrintArray<T>(T[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
bool IsInRange(int index, int length)
{
    return index >= 0 && index < length;
}
double[] FindAverage(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double[] result = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        result[j] = Math.Round((double)sum / rows, 1);
    }
    return result;
}

System.Console.WriteLine("Первая задача");

Console.Write("Укажите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Укажите количество колонок массива: ");
int n = int.Parse(Console.ReadLine());

double[,] arr1 = new double[m, n];
Random rnd = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr1[i, j] = Math.Round((rnd.Next(-10, 10) * rnd.NextDouble()), 1);
    }
}
PrintArray(arr1);

System.Console.WriteLine("========================================================");
System.Console.WriteLine("Вторая задача");
var arr2 = GenerateRandomArray(4, 4);
PrintArray(arr2);
System.Console.WriteLine("Введите индекс искомого элемента.");
Console.WriteLine("Строка: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Колонка: ");
int col = int.Parse(Console.ReadLine());

if (IsInRange(row, arr2.GetLength(0)) && IsInRange(col, arr2.GetLength(1)))
{
    System.Console.WriteLine($"Элемент с этим индексом имеет значение: {arr2[row, col]}");
}
else System.Console.WriteLine("Указанный индекс выходит за пределы массива");

System.Console.WriteLine("========================================================");
System.Console.WriteLine("Третья задача");
var arr3 = GenerateRandomArray(3, 4);
PrintArray(arr3);
var result = FindAverage(arr3);
Console.WriteLine("Среднее арифметическое по колонкам: " + string.Join(" ", result));
