// Lab6_4Recur.cs
// <Возняк Едвард>
// Лабораторна робота № 6.4
// Опрацювання та впорядкування одновимірних динамічних масивів
// Варіант 5
public class Lab6_4Recur
{
    static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter value of a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value of b: ");
        double b = double.Parse(Console.ReadLine());

        double[] array = GenerateArray(n);
        Console.WriteLine("Initial array:");
        PrintArray(array);

        double maxElement = FindMaxElementRecursive(array);
        Console.WriteLine($"\nThe maximum element of the array: {maxElement}");

        int lastPositiveIndex = FindLastPositiveIndex(array);

        double sum = SumUntilLastPositiveRecursive(array, 0 ,lastPositiveIndex);
        Console.WriteLine($"The sum of elements up to last positive element: {sum}");

        CompressArrayRecursive(array, a, b);
        Console.WriteLine("\nModified array after compression:");
        PrintArray(array);
    }

    public static double[] GenerateArray(int n)
    {
        Random random = new Random();
        double[] array = new double[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = Math.Round(random.NextDouble() * 100 - 50, 2);
        }
        return array;
    }
    public static void PrintArray(double[] array, int index = 0)
    {
        if(index >= array.Length)
        {
            Console.WriteLine();
            return;
        }

        Console.Write(index < array.Length - 1 ? $"{array[index]}, " : $"{array[index]}");
        PrintArray(array, index + 1);
    }

    public static double FindMaxElementRecursive(double[] array, int index = 0, double currentMax = double.MinValue)
    {
        if(index >= array.Length)
            return currentMax;

        currentMax = Math.Max(currentMax, array[index]);
        return FindMaxElementRecursive(array, index + 1, currentMax);
    }
    public static int FindLastPositiveIndex(double[] array, int index = 0, int lastPositiveIndex = -1)
    {
        if(index >= array.Length)
            return lastPositiveIndex;

        if (array[index] > 0)
            lastPositiveIndex = index;

        return FindLastPositiveIndex(array, index + 1, lastPositiveIndex);
    }
    public static double SumUntilLastPositiveRecursive(double[] array, int index, int lastPositiveIndex)
    {
        if (index >= lastPositiveIndex)
            return 0;

        return array[index] + SumUntilLastPositiveRecursive(array,index + 1, lastPositiveIndex);
    }
    public static void CompressArrayRecursive(double[] array, double a, double b, int index = 0, int newIndex = 0)
    {
       if(index >= array.Length)
       {
            if(newIndex < array.Length)
            {
                array[newIndex] = 0;
                CompressArrayRecursive(array, a, b, index, newIndex + 1);
            }
            return;
       }

        if (Math.Abs(array[index]) < a || Math.Abs(array[index]) > b)
        {
            array[newIndex] = array[index];
            CompressArrayRecursive(array, a, b, index + 1, newIndex + 1);
        }
        else
        {
            CompressArrayRecursive(array, a, b, index + 1, newIndex);
        }
    }
}
