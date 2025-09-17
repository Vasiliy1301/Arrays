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
        totalSumOfNumbers += numbers[i];
    }

    Console.WriteLine("Outputting an array with a paired index.\n");

    for (int i = 0; i < numbers.Length; i += PairedIndex)
    {
        Console.WriteLine($"Index {i}: {numbers[i]}");
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

    #region Task 4

    const int MINIMUM_VALUE = -100;
    const int MAXIMUM_VALUE = 101;

    Random randomNumbers = new();

    int[,] array = new int[5, 5];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomNumbers.Next(MINIMUM_VALUE, MAXIMUM_VALUE);
        }
    }

    int maximumElement = array[0, 0];
    int minimumElement = array[0, 0];
    int maximumFoundRow = 0;
    int maximumFoundCol = 0;
    int minimumFoundRow = 0;
    int minimumFoundCol = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > maximumElement)
            {
                maximumElement = array[i, j];
                maximumFoundRow = i;
                maximumFoundCol = j;
            }
        
            if (array[i, j] < minimumElement)
            {
                minimumElement = array[i, j];
                minimumFoundRow = i;
                minimumFoundCol = j;
            }
        }
    }

    Console.Write($"\nMaximum element - {maximumElement}, coordinates [{maximumFoundRow},{maximumFoundCol}]" +
                  $"\nMinimum element - {minimumElement}, coordinates [{minimumFoundRow},{minimumFoundCol}]\n");

    #endregion

    #region Task 5

    

    #endregion
}