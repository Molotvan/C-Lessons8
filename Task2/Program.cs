int[][] numbers = new int[5][];
Fill(numbers, 5);
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine("Номер строки с минимальной суммой " + SearchMinSum(numbers) + ", Минимальная сумма равна " + Sum(numbers[SearchMinSum(numbers)], 0));
void PrintArray(int[][] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array[i].Length; j++)
        {

            Console.Write(array[i][j] + " ");
        }
    }
}

void FillArray(int[][] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array[i].Length; j++)
        {
            Random random = new Random();
            array[i][j] = random.Next(1, 10);
        }
    }
}

int Sum(int[] array, int count)
{
    int sum = array[count];
    if (count < array.Length - 1)
    {
        count++;
        sum = sum + Sum(array, count);
    }
    return sum;
}

int SearchMinSum(int[][] array)
{
    int minSum = Sum(array[0], 0);
    int indexMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        int sum;
        sum = Sum(array[i], 0);

        if (sum < minSum)
        {
            minSum = sum;
            indexMin = i;
        }

    }
    return indexMin;
}

void Fill(int[][] array, int innerSize)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new int[innerSize];

    }
}
