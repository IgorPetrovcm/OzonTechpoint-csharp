namespace SolutionsWithTests.Tests;

using TestManager.Attributes;
using System.Text;
using OzonTestsManager;
using OzonTestsManager.Entities;
using System.Globalization;

public class Solutions
{
    OzonCurrentTest ozonTest = OzonTools.CompleteCreation(File.ReadAllLines("Tests/Test.txt"), File.ReadAllLines("Tests/Result.txt"));

    [MethodTesting]
    public string EasyMethod()
    {
        List<DataTaskResult> results = new List<DataTaskResult>();

        for (int i = 0; i < ozonTest.Task.count; i++)
        {
            int[] dateParams = ozonTest.Task.lines.ToArray()[i]
                                .Split(' ').Select(x => int.Parse(x)).ToArray();

            int daysCount = DateTime.DaysInMonth(dateParams[2], dateParams[1]);

            if (dateParams[0] > 0 && dateParams[0] <= daysCount)
                results.Add(new DataTaskResult(i + 1, "yes"));
            else 
                results.Add(new DataTaskResult(i + 1, "no"));
        }

        return ozonTest.TestChecking(results);
    }
}