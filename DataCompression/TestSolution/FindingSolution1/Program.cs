namespace FindingSolution1;

using System.Globalization;
using OzonTestsManager;


public class Program
{
    static void Main()
    {
        OzonTasksBuilder builder = new OzonTasksBuilder();
        builder.SetTask(TaskSettings.IgnoreTitle, File.ReadAllLines("Task.txt"));

        OzonCurrentTest test = builder.Build();

        string[] task = test.ArrayTasks;

        for (int i = 0; i < task.Length; i++)
        {
            int[] numbers = task[i + 1]
                                .Split(' ').Select(x => int.Parse(x)).ToArray();

            for (int j = 1; j < int.Parse(task[i]); j++)
            {
                if (Math.Abs(numbers[j] - numbers[j-1]) == 1)
                {
                    if 
                }
            }
        }
    }
}