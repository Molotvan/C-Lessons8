int[,] numbers = new int[10, 10];
FillArray(numbers);
Console.WriteLine();
PrintArray(numbers);
Console.WriteLine();
PrintArray(DescendingRange(numbers));

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Random random = new Random();
            array[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + " ");
        }
    }
}
int[,] DescendingRange(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int k = j; k >= 0; k--)
            {
                int max;
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    max = numbers[i, k + 1];
                    numbers[i, k + 1] = numbers[i, k];
                    numbers[i, k] = max;
                }
            }
        }
    }
    return numbers;
}