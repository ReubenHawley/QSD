// See https://aka.ms/new-console-template for more information

using Sorting;

int[] array = new int[] { 9, 1, 4, 4, 3, 6, 7, 2, 9 };


var sortedarray = Sort.InsertionSort(array);
Console.WriteLine(string.Join(",", sortedarray));

// sortedarray = Sort.MergeSort(array);
// Console.WriteLine(string.Join(",", sortedarray));

array = new int[] { 4, 9, 5, 1, 2, 8, 3, 6, 7 };
Sort.QuickSortAlgorithm(array);
Console.WriteLine(string.Join(",", array));