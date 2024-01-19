namespace Testing.SolutionClasses;

using BenchmarkDotNet.Attributes;
using Testing.TestFiles;
using System.Text;


[MemoryDiagnoser]
public class QueueSolution
{
    [Benchmark]
    public void CurrentMainMethod()
    {
        LocalTestData testData = LocalTestData.GetTest("../../../../../../../SolutionClasses/tests/test1.txt");

        StringBuilder result = new StringBuilder();

        int[] array = new int[10];

        foreach (string line in testData.Lines)
        {
            array = line.Split(' ').Select(x => int.Parse(x)).ToArray();

            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                queue.Enqueue(array[i], array[i]);
            }

            bool isTrue = true;

            for (int i = 0; i < 4; i++)
            {
                if (queue.Dequeue() != 1)
                {
                    isTrue = false;
                    break;
                }
            }

            if (isTrue == false)
            {
                result.Append("no\n");
                continue;
            }

            for (int j = 0; j < 3; j++)
            {
                if (queue.Dequeue() != 2)
                {
                    isTrue = false;
                    break;
                }
            }
            
            if (isTrue == false)
            {
                result.Append("no\n");
                continue;
            }

            for (int j = 0; j < 2; j++)
            {
                if (queue.Dequeue() != 3)
                {
                    isTrue = false;
                    break;
                }
            }

            if (isTrue == false)
            {
                result.Append("no\n");
                continue;
            }

            if (queue.Dequeue() != 4)
            {
                result.Append("no\n");

                continue;
            }
            
            result.Append("yes\n");
        }

        Console.WriteLine(result.ToString());
    }
}