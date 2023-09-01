namespace QSD;

public class Algorithms
{
    public int LowestCommonDenominator(int a,int b)
    {
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }

        return a;
    }

    public void IncrementalEscalator(int a)
    {
        for (int i = 0; i < a; i++)
        {
            Console.WriteLine("*".PadLeft(i * 2 + 1));
        }
    }

    public int GreatestRandom(int limiter)
    {
        int[] randoms = new int[60];
        int maxnum = 0;
        Random random = new();
        for (int i = 0; i < randoms.Length; i++)
        {
            randoms[i] = random.Next(limiter);
            Console.WriteLine(randoms[i]);
            if (randoms[i] > maxnum)
            {
                maxnum = randoms[i];
            }
        }

        return maxnum;
    }

    public int GreatestRandom(int limiter,int iterations)
    {
        int maxnum = 0;
        Random random = new();
        for (int i = 0; i < iterations; i++)
        {
            var temp = random.Next(limiter);
            Console.WriteLine(temp);
            if (temp > maxnum)
            {
                maxnum = temp;
            }
        }

        return maxnum;
    }

    public void OccurenceCounter(int size,int limiter)
    {
        int[] randoms = new int[size];
        int smallest = limiter;
        int count = 0;
        Random random = new();
        for (int i = 0; i < limiter; i++)
        {
            randoms[i] = random.Next(limiter);
            Console.WriteLine(randoms[i]);
        }

        foreach (var variable in randoms)
        {
            if (variable < smallest)
            {
                smallest = variable;
                count++;
            }
        }

        Console.WriteLine("The smallest number is " + smallest + " and it occurs " + count + " times");
    }

    public void SecondSmallestOccurenceCounter(int size,int limiter)
    {
        int[] randoms = new int[size];
        int smallest = limiter;
        int secondSmallest = limiter;
        int count = 0;
        Random random = new();
        for (int i = 0; i < limiter; i++)
        {
            randoms[i] = random.Next(limiter);
            Console.WriteLine(randoms[i]);
        }

        foreach (var variable in randoms)
        {
            if (variable < smallest)
            {
                smallest = variable;
            }
            else if (variable > smallest && variable < secondSmallest)
            {
                secondSmallest = variable;
                count = 1;
                continue;
            }
            else if (variable == secondSmallest)
            {
                count++;    
            }
        }

        Console.WriteLine("The second smallest number is " + secondSmallest + " and it occurs " + count + " times");
    }
}