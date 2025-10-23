using System;

class Program
{
    public static void Main()
    {
        int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
        quicksort.Sort(integerValues);
        Console.WriteLine(string.Join(" | ", integerValues));

    }
    string[] stringValues = { "Mary", "Marcin", "Ann", "James",
      "George", "Nicole" };
       SelectionSort.Sort(stringValues);
       Console.WriteLine(string.Join(" | ", stringValues));

}