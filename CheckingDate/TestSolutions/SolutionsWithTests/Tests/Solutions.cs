namespace SolutionsWithTests.Tests;

using TestManager.Attributes;
using System.Text;
using OzonTestsManager;


public class Solutions
{
    OzonCurrentTest ozonTest = OzonTools.CompleteCreation(File.ReadAllLines("../../../Tests/Test.txt"), File.ReadAllLines("../../../Tests/Result.txt"));

    [MethodTesting]
    public string EasyMethod()
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < ozonTest.Task.count; i++)
        {
            ReadOnlySpan<char> dateParams = ozonTest.Task.lines.ToArray()[i];

            DateTime isTime = new DateTime();

            if (DateTime.TryParse(dateParams, out isTime))
                result.Append("yes\n");
            else 
                result.Append("no\n");
        }

        return result.ToString();
    }
}