namespace FindingSolution1;

using System.Text;
using OzonTestsManager;

public class Program
{
    static void Main()
    {
        OzonCurrentTest test = OzonTools.CompleteCreation(File.ReadAllLines("Task.txt"),File.ReadAllLines("Result.txt"));

        for (int i = 0; i < test.TaskCount; i++)
        {
            string[] task = test.ArrayTasks;

            YourTaskResult result = new YourTaskResult();

            for (int j = 0; j < task.Length; j++)
            {
                for (int h = 0; h < int.Parse(task[j]); h++)
                {
                    j++;

                    
                }
            }
        }
    }
}