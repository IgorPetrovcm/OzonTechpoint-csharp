namespace SolutionsWithTests;

using SolutionsWithTests.Tests;
using TestManager;

public class Program
{
    static void Main()
    {
        Solutions solution = new Solutions();

        System.Console.WriteLine(solution.EasyMethod());

        TestBuilder tests = new TestBuilder(typeof(Solutions));

        System.Console.WriteLine(tests.GetTests());
    }
}