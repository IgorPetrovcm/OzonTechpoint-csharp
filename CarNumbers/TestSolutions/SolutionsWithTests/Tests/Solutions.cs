namespace SolutionsWithTests;

using System.Text.RegularExpressions;
using OzonTestsManager;
using TestManager.Attributes;

public class Solutions
{
    OzonCurrentTest test = OzonTools.CompleteCreation(File.ReadAllLines("Tests/Task.txt"),File.ReadAllLines("Tests/Result.txt"));

    YourTaskResult result = new YourTaskResult();

    string pattern = @"\D{1}\d{1,2}\D{2}";

    [MethodTesting]
    public void Solution1()
    {
        for (int i = 0; i < test.TaskCount; i++)
        {
            string task = test.ArrayTasks[i];

            string[] matchesLine = new string[task.Length / 4];

            int j = 0;

            foreach (Match match in Regex.Matches(task, pattern))
            {
                task = task.Replace(match.ToString(), "");

                matchesLine[j] = match.ToString();

                j++;
            }

            if (task.Length > 0)
                result.Add("-");
            else 
                result.Add(String.Join(' ', matchesLine));
        }

    }
    [MethodTesting]
    public void MyFirstSolution()
    {
        for (int i = 0; i < test.TaskCount; i++)
        {
            string task = test.ArrayTasks[i];

            string[] matchesLine = new string[task.Length / 4];

            int j = 0;

            if (Regex.Matches(task,pattern).Count > 0)
            {
                foreach (Match match in Regex.Matches(task,pattern))
                {
                    matchesLine[j] = match.ToString();

                    j++;
                }
            }
            else 
            {
                result.Add("-");
                continue;
            }

            if (String.Join("", matchesLine) != task)
                result.Add("-");
            else 
                result.Add(String.Join(' ', matchesLine));
        }

    }



}