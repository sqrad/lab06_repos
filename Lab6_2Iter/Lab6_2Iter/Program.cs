// Lab6_2Iter.cs
// <Возняк Едвард>
// Лабораторна робота № 6.2
// Опрацювання одновимірних масивів ітераційними та рекурсивними способами
// Варіант 5
public class Lab6_2Iter
{
    static void Main(string[] args)
    {
        int size = 25;
        int min = -20;
        int max = 30;

        int[] array = GenerateArray(size, min, max);
        Console.WriteLine("Initial array:");
        PrintArray(array);

        double average = CalculateOddAverage(array);
        Console.WriteLine($"\nArithmetic average of odd elements: {average:F2}");
    }

    public static int[] GenerateArray(int size, int min, int max)
    {
        Random random = new Random();
        int[] array = new int[size];
        for(int i = 0; i < size; i++)
        {
            array[i] = random.Next(min, max + 1);
        }
        return array;
    }
    public static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
    public static double CalculateOddAverage(int[] array)
    {
        int sum = 0;
        int count = 0;

        foreach(int item in array) 
        {
            if(item % 2 != 0)
            {
                sum += item;
                count++;
            }
        }

        return count > 0 ? (double)sum / count : 0;
    }
}

