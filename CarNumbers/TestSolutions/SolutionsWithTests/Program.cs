namespace SolutionsWithTests;

using TestManager;


public class Program
{
    static void Main()
    {
        Solutions solutions = new Solutions();
        System.Console.WriteLine(solutions.MyFirstSolution());

        TestBuilder testBuilder = new TestBuilder(typeof(Solutions));

        System.Console.WriteLine(testBuilder.GetTests());
    }
}