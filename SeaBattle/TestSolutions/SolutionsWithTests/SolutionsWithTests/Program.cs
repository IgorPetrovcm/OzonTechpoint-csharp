namespace SolutionsWithTests;

using TestManager;
using SolutionsWithTests.Tests;


public class Program
{
	static void Main()
	{
		TestBuilder tests = new TestBuilder(typeof(Solutions));

        Console.WriteLine(tests.GetTests());
    }
}