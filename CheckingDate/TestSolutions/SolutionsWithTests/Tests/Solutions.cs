namespace SolutionsWithTests.Tests;

using TestManager.Attributes;
using System.Text;


public class Solutions
{
    LocalTestTasks task = LocalTestTasks.AddTask(File.ReadAllLines("Tests/Test.txt"));

    [MethodTesting]
    public string EasyMethod()
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < task.CountLines; i++)
        {
            ReadOnlySpan<char> dateParams = task.Lines.ToArray()[i];

            DateTime isTime = new DateTime();

            if (DateTime.TryParse(dateParams, out isTime))
                result.Append("yes\n");
            else 
                result.Append("no\n");
        }

        return result.ToString();
    }
}