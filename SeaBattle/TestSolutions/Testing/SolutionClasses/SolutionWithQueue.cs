namespace Testing.SolutionClasses;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Testing.TestFiles;


BenchmarkRunner.Run<QueueSolution>();

[MemoryDiagnoser]
public class QueueSolution
{
    [Benchmark]
    public void CurrentMainMethod()
    {

    }
}