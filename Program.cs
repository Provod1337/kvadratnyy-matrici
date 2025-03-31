
Console.Write("Введите количество столбцов массива: ");
string dlina = Convert.ToString(Console.ReadLine());

foreach (char c in dlina)
{
    if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
    {
    }
    else
    {
        Console.WriteLine("Вы ввели недопустимый символ");
        return;
    }
}
int dlina1 = Convert.ToInt32(dlina);

Random random = new Random();
int[] a1 = new int[dlina1];

Console.WriteLine("Введите количество строк массива: ");
string shirina = Convert.ToString(Console.ReadLine());
foreach (char c in shirina)
{
    if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
    {
    }
    else
    {
        Console.WriteLine("Вы ввели недопустимый символ");
        return;
    }
}
int shirina1 = Convert.ToInt32(shirina);

int[,] A1 = new int[dlina1, shirina1];

Console.WriteLine("Введите нижний диапазон чисел, которые будут заполнять массив");
string minDiapozon = Convert.ToString(Console.ReadLine());
foreach (char c in minDiapozon)
{
    if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
    {
    }
    else
    {
        Console.WriteLine("Вы ввели недопустимый символ");
        return;
    }
}
int minRange = Convert.ToInt32(minDiapozon);

Console.WriteLine("Введите верхний диапазон чисел, которые будут заполнять массив");
string maxDiapozon = Convert.ToString(Console.ReadLine());
foreach (char c in maxDiapozon)
{
    if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
    {
    }
    else
    {
        Console.WriteLine("Вы ввели недопустимый символ");
        return;
    }
}
int maxRange = Convert.ToInt32(maxDiapozon);

if (maxRange <= minRange)
{
    Console.WriteLine("Ошибка: верхний диапазон должен быть больше или равен нижнему");
    return;
}

FillMatrix(A1, minRange, maxRange, random);
PrintMatrix(A1);


static void FillMatrix(int[,] matrix, int min, int max, Random rnd)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
}

static void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"|{matrix[i, j]}|");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
