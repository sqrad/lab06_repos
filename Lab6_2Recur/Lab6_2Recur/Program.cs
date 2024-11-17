// Lab6_2Recur.cs
// <Возняк Едвард>
// Лабораторна робота № 6.2
// Опрацювання одновимірних масивів ітераційними та рекурсивними способами
// Варіант 5
public class Lab6_2Recur
{
    static void Main(string[] args)
    {
        int size = 25;
        int min = -20;
        int max = 30;

        int[] array = GenerateArray(size, min, max);
        Console.WriteLine("Initial array:");
        PrintArrayRecursive(array, 0);

        int sum = SumOddRecursive(array, 0);
        int count = CountOddRecursive(array, 0);

        double average = count > 0 ? (double)sum / count : 0;
        Console.WriteLine($"\nArithmetic average of odd elements: {average:F2}");
    }

    public static int[] GenerateArray(int size, int min, int max)
    {
        Random random = new Random();
        int[] array = new int[size];
        return GenerateArrayRecursive(array, 0, min, max, random);
    }
    public static int[] GenerateArrayRecursive(int[] array, int index, int min, int max, Random random)
    {
        if (index >= array.Length)
            return array;

        array[index] = random.Next(min, max + 1);
        return GenerateArrayRecursive(array, index + 1, min, max, random);
    }
    public static void PrintArrayRecursive(int[] array, int index)
    {
        if (index >= array.Length)
        {
            Console.WriteLine();
            return;
        }

        if (index < array.Length - 1)
            Console.Write($"{array[index]}, ");
        else
            Console.Write($"{array[index]}");

        PrintArrayRecursive(array, index + 1);
    }
    public static int SumOddRecursive(int[] array, int index)
    {
        if (index >= array.Length)
            return 0;

        int sum = (array[index] % 2 != 0) ? array[index] : 0;
        return sum + SumOddRecursive(array, index + 1);
    }
    public static int CountOddRecursive(int[] array, int index)
    {
        if (index >= array.Length)
            return 0;

        int count = (array[index] % 2 != 0) ? 1 : 0;
        return count + CountOddRecursive(array, index + 1);
    }
}
