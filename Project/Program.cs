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
}