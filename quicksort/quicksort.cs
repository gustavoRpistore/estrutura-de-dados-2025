using System;

namespace quicksort
{
    public static class quicksort
    {
        public static void sort<T>(T[] array) where T : IComparable<T>
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (array.Length <= 1) return;
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort<T>(T[] array, int lower, int upper) where T : IComparable<T>
        {
            if (lower >= upper) return;
            int p = Partition(array, lower, upper);
            Sort(array, lower, p);
            Sort(array, p + 1, upper);
        }

        private static int Partition<T>(T[] array, int lower, int upper) where T : IComparable<T>
        {
            int i = lower;
            int j = upper;
            T pivot = array[(lower + upper) / 2];

            while (true)
            {
                while (array[i].CompareTo(pivot) < 0) i++;
                while (array[j].CompareTo(pivot) > 0) j--;
                if (i >= j) return j;
                Swap(array, i, j);
                i++;
                j--;
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