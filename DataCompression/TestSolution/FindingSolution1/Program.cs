namespace FindingSolution1;

using System.Runtime.InteropServices;
using System.Text;
using OzonTestsManager;


public class Program
{
    static void Main()
    {
        OzonTasksBuilder builder = 
                OzonTools.CreateBuilderWithBasicSettings(TaskSettings.IgnoreTitle, 
                        File.ReadAllLines("Task.txt"), File.ReadAllLines("Result.txt")
                    );

        OzonCurrentTest test = builder.Build();

        YourTaskResult result = new YourTaskResult();

        string[] task = test.ArrayTasks;

        for (int i = 1; i < task.Length; i++)
        {
            i++;

            int[] numbers = task[i].Split(' ')
                                .Select(x => int.Parse(x)).ToArray();

            int j = 0;

            int h = 0;

            LinkedList<int> resultNumbers = new LinkedList<int>();

            while (j + h <= numbers.Length - 1)
            {
                h = h + j;

                int current = numbers[h];

                j = 1;

                if (h + j > numbers.Length - 1)
                {
                    resultNumbers.AddLast(current);
                    resultNumbers.AddLast(0);

                    break;
                }

                bool state = false;

                if (current - numbers[h + j] > 0)
                    state = true;

                while ( h + j <= numbers.Length - 1 && Math.Abs(numbers[h + j] - current) == 1)
                {
                    if ((current - numbers[h + j] > 0) != state)
                    {
                        break;
                    }

                    current = numbers[h + j];

                    j++;
                }

                resultNumbers.AddLast(numbers[h]);
                resultNumbers.AddLast(numbers[j + h - 1] - numbers[h]);
            }

            result.Add(resultNumbers.Count.ToString());
            result.Add(resultNumbers);


        }

        Console.WriteLine(test.TestChecking(result));
    }
}