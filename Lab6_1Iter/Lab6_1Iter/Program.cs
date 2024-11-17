// Lab6_1Iter.cs
// <Возняк Едвард>
// Лабораторна робота № 6.1
// Пошук елементів одновимірного масиву ітераційним та рекурсивним способом
// Варіант 5
public class Lab6_1Iter
{
    static void Main(string[] args)
    {
        int size = 25;
        int min = -20;
        int max = 30;

        int[] array = GenerateArray(size, min, max);
        Console.WriteLine("Initial array:");
        PrintArray(array);

        int count = CountFiltered(array);
        int sum = SumFiltered(array);
        Console.WriteLine($"\nNumber of positive even elements: {count}");
        Console.WriteLine($"The sum of positive even elements: {sum}");

        ReplaceFilteredWithZeros(array);
        Console.WriteLine("\nModified array:");
        PrintArray(array);
    }

    public static int[] GenerateArray(int size, int min, int max)
    {
        Random random = new Random();
        int[] array = new int[size];
        for(int i = 0;i < size; i++)
        {
            array[i] = random.Next(min, max + 1);
        }

        return array;
    }
    public static void PrintArray(int[] array) 
    {
        Console.WriteLine(string.Join(", ", array));
    }
    public static int CountFiltered(int[] array)
    {
        int count = 0;
        foreach(int item in array)
        {
            if(item > 0 && item % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
    public static int SumFiltered(int[] array)
    {
        int sum = 0;
        foreach (int item in array)
        {
            if(item > 0 && item % 2 == 0)
            {
                sum += item;
            }
        }
        return sum;
    }
    public static void ReplaceFilteredWithZeros(int[] array)
    {
        for(int i = 0;i < array.Length; i++)
        {
            if (array[i] >0 && array[i] % 2 == 0)
            {
                array[i] = 0;
            }
        }
    }
}

