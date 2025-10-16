using System;

namespace SelectionSort
{

    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length < 2) return;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                    Swap(array, i, minIndex);
            }
        }

        public static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}