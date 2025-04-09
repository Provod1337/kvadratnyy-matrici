Random random = new Random();
Console.WriteLine("Введите количество столбцов массива: ");
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

if (dlina1 == 0)
{
    Console.WriteLine("Вы ввели 0 столбцов");
    return;
}

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

if (shirina1 == 0)
{
    Console.WriteLine("Вы ввели 0 строк");
    return;
}

int[,] A1 = new int[shirina1, dlina1];
int[,] B1 = new int[shirina1, dlina1];

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

int rows = A1.GetLength(0); 
int cols = A1.GetLength(1);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        A1[i, j] = random.Next(minRange, maxRange + 1);
        B1[i, j] = random.Next(minRange, maxRange + 1);
    }
}

Console.WriteLine("Матрица A:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{A1[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine("Матрица B:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{B1[i, j]} \t");
    }
    Console.WriteLine();
}

int[,] sumMatrix = new int[shirina1, dlina1];

for (int i = 0; i < shirina1; i++)
{
    for (int j = 0; j < dlina1; j++)
    {
        sumMatrix[i, j] = A1[i, j] + B1[i, j];
    }
}

Console.WriteLine("Результат сложения матриц:");
for (int i = 0; i < shirina1; i++)
{
    for (int j = 0; j < dlina1; j++)
    {
        Console.Write($"{sumMatrix[i, j]} \t");
    }
    Console.WriteLine();
}

int[,] diffMatrix = new int[shirina1, dlina1];

for (int i = 0; i < shirina1; i++)
{
    for (int j = 0; j < dlina1; j++)
    {
        diffMatrix[i, j] = A1[i, j] - B1[i, j];
    }
}

Console.WriteLine("Результат вычитания матриц:");
for (int i = 0; i < shirina1; i++)
{
    for (int j = 0; j < dlina1; j++)
    {
        Console.Write($"{diffMatrix[i, j]} \t");
    }
    Console.WriteLine();
}
