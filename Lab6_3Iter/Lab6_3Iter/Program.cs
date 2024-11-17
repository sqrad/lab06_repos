// Lab6_3Iter.cs
// <Возняк Едвард>
// Лабораторна робота № 6.3
// Опрацювання одновимірних масивів за допомогою звичайних функцій та шаблонів
// Варіант 5
public class Lab6_3Iter
{
    static void Main(string[] args)
    {
        int size = 25;
        int min = -20;
        int max = 30;

        int[] array = GenerateArray(size, min, max);
        Console.WriteLine("Initial array:");
        PrintArray(array);

        SortArrayDescending(array);
        Console.WriteLine("\nArray after non-increasing sort:");
        PrintArray(array);
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
    public static void SortArrayDescending(int[] array)
    {
        for(int i = 0;i < array.Length - 1;i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] < array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
