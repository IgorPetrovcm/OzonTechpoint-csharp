namespace FindingSolution1;

using System.Text;
using OzonTestsManager;

public class Program
{
    static void Main()
    {
        OzonCurrentTest test = OzonTools.CompleteCreation(File.ReadAllLines("Task.txt"),File.ReadAllLines("Result.txt"));

        string[] task = test.ArrayTasks;

        YourTaskResult result = new YourTaskResult();

        for (int j = 0; j < task.Length; j++)
        {
            int[] interval = {15, 30};

            bool isError = false;

            int employeeCount = int.Parse(task[j]);

            for (int h = 0; h < employeeCount; h++)
            {
                j++;

                if (isError == true)
                {
                    result.Add("-1");

                    continue;
                }

                if (task[j][0] == '>')
                {
                    int newIntervalNumber = int.Parse(task[j][3].ToString() + task[j][4].ToString());

                    if (newIntervalNumber > interval[0])
                        interval[0] = newIntervalNumber;
                }
                else 
                {
                    int newIntervalNumber = int.Parse(task[j][3].ToString() + task[j][4].ToString());

                    if (newIntervalNumber < interval[1])
                        interval[1] = newIntervalNumber;
                }

                if (interval[1] < interval[0])
                {
                    isError = true;

                    result.Add("-1");

                    continue;
                }

                result.Add(interval[0].ToString());
            }

            result.Add("");
        }

        System.Console.WriteLine(test.TestChecking(result));
    }
}