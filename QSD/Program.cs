// See https://aka.ms/new-console-template for more information

using QSD;

Console.WriteLine("Common Denominator test");

Algorithms algorithms = new();

Console.WriteLine("Exercise 1:");

Console.WriteLine("The lowest common denominator is " +
    algorithms.LowestCommonDenominator(50, 35));
Console.WriteLine("*****************************************************************");

Console.WriteLine("Exercise 2:");
Console.WriteLine("Incremental Escalator");
algorithms.IncrementalEscalator(5);
Console.WriteLine("*****************************************************************");

Console.WriteLine("Exercise 3a:");
Console.WriteLine("Random Number Generator");
var maxnum = algorithms.GreatestRandom(100);
Console.WriteLine("The greatest random number is " + maxnum);
Console.WriteLine("*****************************************************************");

Console.WriteLine("Exercise 3b:");
Console.WriteLine("Random Number Generator");
maxnum = algorithms.GreatestRandom(100,60);
Console.WriteLine("The greatest random number is " + maxnum);
Console.WriteLine("*****************************************************************");

Console.WriteLine("Exercise 4:");
Console.WriteLine("Occurence Counter");
algorithms.OccurenceCounter(30,30);
Console.WriteLine("*****************************************************************");

Console.WriteLine("Exercise 4:");
Console.WriteLine("Occurence Counter");
algorithms.SecondSmallestOccurenceCounter(10,10);
Console.WriteLine("*****************************************************************");
