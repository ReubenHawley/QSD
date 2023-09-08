// See https://aka.ms/new-console-template for more information

// generate a random array with positive an negative values

using Algorithms_DataStructures;

var random = new Random();
var randomArray = new int[1000];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = random.Next(-100,100);
}

Console.WriteLine($"Random array: {string.Join(",",randomArray)}");
System.DateTime start = System.DateTime.Now;
Console.WriteLine($"Max sub sum: {Algorithms.SuperSlowMaxSubSum(randomArray)}");
System.DateTime end = System.DateTime.Now;
Console.WriteLine($"Time elapsed: {(end-start).TotalMilliseconds} ms");

start = System.DateTime.Now;
Console.WriteLine($"Max sub sum: {Algorithms.OptimizedMaxSubSum(randomArray)}");
end = System.DateTime.Now;
Console.WriteLine($"Time elapsed: {(end-start).TotalMilliseconds} ms");

start = System.DateTime.Now;
Console.WriteLine($"Max sub sum: {Algorithms.HighlyOptimizedMaxSubSum(randomArray)}");
end = System.DateTime.Now;
Console.WriteLine($"Time elapsed: {(end-start).TotalMilliseconds} ms");

