//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
//-------------------------------------------------------

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод.");
        }
    }

    return result;
}
int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] matrix)
{
      for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double summ = 0;
        double mean = 0;

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            summ += matrix[j , i];
            mean = Math.Round(summ / (j + 1), 2);
        }
        Console.Write($"Сумма чисел в столбцах: {summ}, среднее значение: ");
        Console.WriteLine($"{mean} ");
    }
}

int countOfRows = GetNumber("Введите кол-во строк:");
int countOfColumns = GetNumber("Введите кол-во столбцов:");
int[,] matrix = InitMatrix(countOfRows, countOfColumns);

PrintMatrix(matrix);
ArithmeticMean(matrix);

//-----------------------------------------------------------
//Пример нахождения суммы со https://www.cyberforum.ru/
/*
Console.WriteLine("Enter dimension: ");
            int n = Int32.Parse(Console.ReadLine());
            
            int[,] arr = new int[n, n];
            Random rnd = new Random();
 
            for (short i = 0; i < n; i++)
                for (short j = 0; j < n; j++)
                    arr[i, j] = rnd.Next(1, 20);
 
            for(short i = 0; i < n; i++)
            {
                for (short j = 0; j < n; j++)
                    Console.Write(arr[i,j] + " ");
                Console.WriteLine();
            }
 
            for (short i = 0; i < n; i++)
            {
                int sum = 0;
                for (short j = 0; j < n; j++)
                {
                    sum += arr[j, i];
                }
                Console.WriteLine("Sum in {0} column: {1}", i, sum);
            }
*/