namespace Arrays;

public class Program
{
    #region Task 1,2

    Random randomNumber = new();

    const int MINIMUM_VALUE = -10;
    const int MAXIMUM_VALUE = 11;

    int[] numbers = new int[10];

    int totalSumOfNumbers = 0;
    int PairedIndex = 2;

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = randomNumber.Next(MINIMUM_VALUE, MAXIMUM_VALUE);
    }

    Console.WriteLine("Outputting an array with a paired index.\n");

    for (int i = 0; i < numbers.Length; i += PairedIndex)
    {
        Console.WriteLine($"Index {i}: {numbers[i]}");
        totalSumOfNumbers += numbers[i];
    }

    Console.WriteLine();

    Console.WriteLine(totalSumOfNumbers >= 0
    ? $"The total sum of the numbers is positive = {totalSumOfNumbers}."
    : $"The total sum of the numbers is negative = {totalSumOfNumbers}.");

    #endregion
    
    #region Task 3
    
    const int INCREASE_BY_ONE = 1;

    int[,] multiplicationTable = new int[9, 9];

    int numbersMultiplication = multiplicationTable.GetLength(0);
    int columnsMultiplications = multiplicationTable.GetLength(1);

        for (int i = 0; i < numbersMultiplication; i++)
    {
        for (int j = 0; j < columnsMultiplications; j++)
        {
            multiplicationTable[i, j] = (i + INCREASE_BY_ONE) * (j + INCREASE_BY_ONE);
        }
    }

    for (int i = 0; i < numbersMultiplication; i++)
    {
        for (int j = 0; j < columnsMultiplications; j++)
        {
            Console.WriteLine($"Row: {i + INCREASE_BY_ONE}: {i + INCREASE_BY_ONE} x {j + INCREASE_BY_ONE} = {multiplicationTable[i, j]}");
        }
    }

    #endregion
}