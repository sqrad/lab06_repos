// Lab6_4Iter.cs
// <Возняк Едвард>
// Лабораторна робота № 6.4
// Опрацювання та впорядкування одновимірних динамічних масивів
// Варіант 5
public class Lab6_4Iter
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

        double maxElement = FindMaxElement(array);
        Console.WriteLine($"\nThe maximum element of the array: {maxElement}");

        double sum = SumUntilLastPositive(array);
        Console.WriteLine($"The sum of elements up to last positive element: {sum}");

        CompressArray(ref array, a, b);
        Console.WriteLine("\nModified array after compression:");
        PrintArray(array);
    }

    public static double[] GenerateArray(int n)
    {
        Random random = new Random();
        double[] array = new double[n];
        for(int i = 0; i < n; i++)
        {
            array[i] = Math.Round(random.NextDouble() * 100 - 50, 2);
        }
        return array;
    }
    public static void PrintArray(double[] array)
    {
        Console.WriteLine(string.Join(",", array));
    }

    public static double FindMaxElement(double[] array)
    {
        double max = array[0];
        for(int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
    public static double SumUntilLastPositive(double[] array)
    {
        int lastPositiveIndex = -1;
        for(int i = 0;i < array.Length;i++)
        {
            if (array[i] > 0)
            {
                lastPositiveIndex = i;
            }
        }

        if (lastPositiveIndex == -1) return 0;

        double sum = 0;
        for(int i = 0;i < lastPositiveIndex; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    public static void CompressArray(ref double[] array, double a, double b)
    {
        int newIndex = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i]) < a || Math.Abs(array[i]) > b)
            {
                array[newIndex++] = array[i];
            }
        }

        for(int i = newIndex; i < array.Length; i++)
        {
            array[i] = 0;
        }
    }
}
