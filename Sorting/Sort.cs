namespace Sorting;

public class Sort
{
    /// <summary>
    /// Insertions sort uses right shifting to insert smaller elements to the left of the array.
    /// Insertion Sort has a time complexity of O(n^2) and a space complexity of O(1).
    /// Best case O(n) when the array is already sorted.
    /// Worst case O(n^2) when the array is reverse sorted.
    /// Best used for small arrays.
    /// </summary>
    /// <param name="array"> An array of integers</param>
    /// <returns> sorted array of integers</returns>
    public static int[] InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int j = i;
            while (j > 0 && array[j - 1] > array[j])
            {
                (array[j - 1], array[j]) = (array[j], array[j - 1]);
                j--;
            }
        }

        return array;
    }

    /// <summary>
    /// Shell sort is a variation of insertion sort that uses a gap to sort elements.
    /// Shell sort has a time complexity of O(n^2) and a space complexity of O(1).
    /// Best case O(n) when the array is already sorted.
    /// Worst case O(n^2) when the array is reverse sorted.
    /// Best used for small arrays.
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static int[] ShellSort(int[] array)
    {
        int n = array.Length;
        int gap = n / 2;
        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = array[i];
                int j = i;
                while (j >= gap && array[j - gap] > temp)
                {
                    array[j] = array[j - gap];
                    j -= gap;
                }

                array[j] = temp;
            }

            gap /= 2;
        }

        return array;
    }

    /// <summary>
    /// The merge sort algorithm uses a divide and conquer approach to sorting.
    /// Merge sort has a time complexity of O(nlogn) and a space complexity of O(n).
    /// The best case is O(nlogn) when the array is already sorted.
    /// The worst case is O(nlogn) when the array is reverse sorted.
    /// The merge sort algorithm is best used for large arrays.
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static int[] MergeSort(int[] array)
    {
        int length = array.Length;
        if (length <= 1) return array; // base case

        int middle = length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[length - middle];
        int i = 0;
        int j = 0;

        // populate left array
        for (; i < middle; i++)
        {
            if (i < middle)
            {
                leftArray[i] = array[i];
            }
            else
            {
                rightArray[j] = array[i];
                j++;
            }
        }

        MergeSort(leftArray);
        MergeSort(rightArray);
        return Merge(leftArray, rightArray, array);
    }

    private static int[] Merge(int[] leftArray, int[] rightArray, int[] array)
    {
        int leftSize = array.Length / 2;
        int rightSize = array.Length - leftSize;
        int i = 0, left = 0, right = 0; //indices

        //check for conditions for merging
        while (left < leftSize)
        {
            if (leftArray[left] < rightArray[right])
            {
                array[i] = leftArray[left];
                i++;
                left++;
            }
            else
            {
                array[i] = rightArray[right];
                i++;
                right++;
            }
        }

        while (left < leftSize)
        {
            array[i] = leftArray[left];
            i++;
            left++;
        }

        while (right < rightSize)
        {
            array[i] = rightArray[right];
            i++;
            right++;
        }

        return array;
    }

    /// <summary>
    /// The Quick Sort algorithm uses a divide and conquer approach to sorting.
    /// Quick sort has a time complexity of O(nlogn) and a space complexity of O(1).
    /// The best case is O(nlogn) when the array is already sorted.
    /// The worst case is O(nlogn) when the array is reverse sorted.
    /// THe average case is O(nlogn).
    /// Quick sort is best used for arrays  greater than 10 elements.
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static int[] QuickSort(int[] array)
    {
        int i = 0;
        int j = array.Length - 2;

        //obtain the median of the first, middle and last element
        int pivot = Median(array[0], array[array.Length / 2], array[^1]);
        int pivotIndex = GetIndex(pivot, array);
        Console.WriteLine("Pivot: " + pivot + "index: " + pivotIndex);
        //swap the median with the last element
        (array[^1], array[pivotIndex]) = (array[pivotIndex], array[^1]);

        //partition the array
        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }

            while (array[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                (array[i], array[j]) = (array[j], array[i]);
                Console.WriteLine(string.Join(",", array));
                i++;
                j--;
            }

            if (i > j)
            {
                //swap the median with the last element
                (array[^1], array[i]) = (array[i], array[^1]);
            }
        }

        return array;
    }

    /// <summary>
    /// Median is a helper function for QuickSort.
    /// Median returns the median value of three integers.
    /// </summary>
    /// <param name="i"></param>
    /// <param name="i1"></param>
    /// <param name="i2"></param>
    /// <returns></returns>
    private static int Median(int i, int i1, int i2)
    {
        if (i > i1)
        {
            if (i1 > i2)
            {
                return i1;
            }
            else if (i > i2)
            {
                return i2;
            }
            else
            {
                return i;
            }
        }
        else
        {
            if (i > i2)
            {
                return i;
            }
            else if (i1 > i2)
            {
                return i2;
            }
            else
            {
                return i1;
            }
        }
    }

    /// <summary>
    /// Get index is a helper function for QuickSort.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="array"></param>
    /// <returns></returns>
    private static int GetIndex(int value, int[] array)
    {
        int index = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == value)
            {
                index = i;
            }
        }

        return index;
    }


    public static void QuickSortAlgorithm(int[]? arr)
    {
        if (arr == null || arr.Length <= 1)
            return;

        QuickSortRecursive(arr, 0, arr.Length - 1);
    }

    static void QuickSortRecursive(int[]? arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);
            QuickSortRecursive(arr, low, pivotIndex - 1);
            QuickSortRecursive(arr, pivotIndex + 1, high);
        }
    }

    static int Partition(int[]? arr, int low, int high)
    {
        // Choose the pivot using median of three principle
        int mid = (low + high) / 2;

        if (arr[low] > arr[mid])
            Swap(arr, low, mid);

        if (arr[low] > arr[high])
            Swap(arr, low, high);

        if (arr[mid] > arr[high])
            Swap(arr, mid, high);

        int pivotValue = arr[mid];
        int left = low + 1;
        int right = high;

        while (true)
        {
            while (left <= right && arr[left] < pivotValue)
                left++;

            while (left <= right && arr[right] > pivotValue)
                right--;

            if (left <= right)
            {
                Swap(arr, left, right);
                left++;
                right--;
            }
            else
            {
                break;
            }
        }

        Swap(arr, mid, right);
        return right;
    }

    static void Swap(int[]? arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}