// Lab6_1Recur.cs
// <Возняк Едвард>
// Лабораторна робота № 6.1
// Пошук елементів одновимірного масиву ітераційним та рекурсивним способом
// Варіант 5
public class Lab6_1Recur
{
    static void Main(string[] args)
    {
        int size = 25;
        int min = -20;
        int max = 30;

        int[] array = GenerateArray(size, min, max);
        Console.WriteLine("Initial array:");
        PrintArrayRecursive(array, 0);

        int count = CountFilteredRecursive(array, 0);
        int sum = SumFilteredRecursive(array, 0);
        Console.WriteLine($"\nNumber of positive even elements: {count}");
        Console.WriteLine($"The sum of positive even elements: {sum}");

        ReplaceFilteredWithZerosRecursive(array, 0);
        Console.WriteLine("\nModified array:");
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

        array[index] = random.Next(min, max + 1);
        return GenerateArrayRecursive(array, index + 1, min, max, random);
    }
    public static void PrintArrayRecursive(int[] array, int index)
    {
        if(index >= array.Length)
        {
            Console.WriteLine();
            return;
        }

        if (index == array.Length - 1)
            Console.Write($"{array[index]}");
        else
            Console.Write($"{array[index]}, ");

        PrintArrayRecursive(array, index + 1);
    }
    public static int CountFilteredRecursive(int[] array, int index)
    {
        if(index >= array.Length)
            return 0;

        int count = (array[index] > 0 && array[index] % 2 == 0) ? 1:0;
        return count + CountFilteredRecursive(array, index + 1);
    }
    public static int SumFilteredRecursive(int[] array, int index)
    {
        if (index >= array.Length)
            return 0;
        
        int sum = (array[index] > 0 && array[index] % 2 == 0) ? array[index] : 0;
        return sum + SumFilteredRecursive(array, index + 1);
    }
    public static void ReplaceFilteredWithZerosRecursive(int[] array, int index)
    {
        if (index >= array.Length)
            return;

        if (array[index] > 0 && array[index] % 2 == 0)
            array[index] = 0;

        ReplaceFilteredWithZerosRecursive(array, index + 1);
    }
}
