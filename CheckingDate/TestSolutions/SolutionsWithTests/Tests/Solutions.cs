namespace SolutionsWithTests.Tests;

using TestManager.Attributes;
using System.Text;
using OzonTestsManager;
using OzonTestsManager.Entities;


public class Solutions
{
    OzonCurrentTest ozonTest = OzonTools.CompleteCreation(File.ReadAllLines("Tests/Test.txt"), File.ReadAllLines("Tests/Result.txt"));

    [MethodTesting]
    public string EasyMethod()
    {
        List<DataTaskResult> results = new List<DataTaskResult>();

        for (int i = 0; i < ozonTest.Task.count; i++)
        {
            ReadOnlySpan<char> dateParams = ozonTest.Task.lines.ToArray()[i];

            DateTime isTime = new DateTime();

            if (DateTime.TryParse(dateParams, out isTime))
                results.Add(new DataTaskResult(i + 1, "yes"));
            else 
                results.Add(new DataTaskResult(i + 1, "no"));
        }

        return ozonTest.TestChecking(results);
    }
}