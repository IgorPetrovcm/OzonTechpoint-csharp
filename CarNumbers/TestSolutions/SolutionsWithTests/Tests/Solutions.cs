namespace SolutionsWithTests;

using System.Text.RegularExpressions;
using OzonTestsManager;
using TestManager.Attributes;

public class Solutions
{
    OzonCurrentTest test = OzonTools.CompleteCreation(File.ReadAllLines("Tests/Task.txt"),File.ReadAllLines("Tests/Result.txt"));

    [MethodTesting]
    public string MyFirstSolution()
    {
        YourTaskResult result = new YourTaskResult();

        string pattern = @"\D{1}\d{1,2}\D{2}";

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
                result.Add("no");
                continue;
            }

            if (String.Join("", matchesLine) != task)
                result.Add("-");
            else 
                result.Add(String.Join(' ', matchesLine));
        }

        return test.TestChecking(result);
    }
}