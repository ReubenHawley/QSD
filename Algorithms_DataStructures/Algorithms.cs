namespace Algorithms_DataStructures;

public class Algorithms
{
    public int Sum(int[] a,int b,int e)
    {
        int sum = 0;
        for (int i = b; i <= e; i++)
        {
            sum += a[i];
        }

        return sum;
    }

    /// <summary>
    /// A brute force implementation of the max sum of a subset of an array
    /// </summary>
    /// <param name="a"> array of integer values</param>
    /// <returns></returns>
    public static int SuperSlowMaxSubSum(int[] a)
    {
        int maxSum = 0;
        for (int i = 0; i < a.Length; i++) // First N 
        {
            for (int j = i; j < a.Length; j++) // Second N
            {
                int thisSum = 0;
                for (int k = i; k <= j; k++) // Third N  
                {
                    thisSum += a[k];
                }

                if (thisSum > maxSum)
                {
                    maxSum = thisSum;
                }
            }
        }

        return maxSum;
    }

    /// <summary>
    /// A slightly optimized implementation of the max sum of a subset of an array
    /// </summary>
    /// <returns></returns>
    /// <param name="a"> array of integer values</param>
    public static int OptimizedMaxSubSum(int[] a)
    {
        int maxSum = 0;
        for (int i = 0; i < a.Length; i++) // First N 
        {
            int thisSum = 0;
            for (int j = i; j < a.Length; j++) // Second N
            {
                thisSum += a[j];
                if (thisSum > maxSum)
                {
                    maxSum = thisSum;
                }
            }
        }

        return maxSum;
    }

    /// <summary>
    /// Highly optimized implementation of the max sum of a subset of an array
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    public static int HighlyOptimizedMaxSubSum(int[] a)
    {
        int maxSum = 0;
        int thisSum = 0;
        for (int i = 0; i < a.Length; i++) // First N 
        {
            thisSum += a[i];
            if (thisSum > maxSum)
            {
                maxSum = thisSum;
            }
            else if (thisSum < 0)
            {
                thisSum = 0;
            }
        }

        return maxSum;
    }
}