// Lab6_3Recur.cs
// <Возняк Едвард>
// Лабораторна робота № 6.3
// Опрацювання одновимірних масивів за допомогою звичайних функцій та шаблонів
// Варіант 5
public class Lab6_3Recur
{
    static void Main(string[] args)
    {
        int size = 25;
        int min = -20;
        int max = 30;

        int[] array = GenerateArray(size, min, max);
        Console.WriteLine("Initial array:");
        PrintArrayRecursive(array, 0);

        SortArrayDescendingRecursive(array, array.Length);
        Console.WriteLine("\nArray after non-increasing sort:");
        PrintArrayRecursive(array, 0);
    }

    public static int[] GenerateArray(int size, int min, int max)
    {
        Random random = new Random();
        int[] array = new int[size];
        
        return GenerateArrayRecursive(array, 0, min, max, random);
    }
    public static int[] GenerateArrayRecursive(int[] array, int index, int min, int max, Random random)
    {
        if(index >= array.Length)
            return array;

        array[index] = random.Next(min,max + 1);
        return GenerateArrayRecursive(array, index + 1, min, max, random); 
    }
    public static void PrintArrayRecursive(int[] array, int index)
    {
        if(index >= array.Length)
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
    public static void SortArrayDescendingRecursive(int[] array, int n)
    {
        if (n == 1)
            return;

        for(int i = 0; i < n - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }

        SortArrayDescendingRecursive(array, n - 1);
    }
}
