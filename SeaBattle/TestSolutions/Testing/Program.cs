namespace Testing;

using Testing.SolutionClasses;
using BenchmarkDotNet.Running;

public class Program 
{
    static void Main()
    {
        BenchmarkRunner.Run<QueueSolution>();
    }
}