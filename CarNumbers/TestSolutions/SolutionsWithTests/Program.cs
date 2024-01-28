namespace SolutionsWithTests;

using TestManager;


public class Program
{
    static void Main()
    {
        /*Solutions solutions = new Solutions();
        System.Console.WriteLine(solutions.Solution1());*/

        TestBuilder testBuilder = new TestBuilder(typeof(Solutions));

        System.Console.WriteLine(testBuilder.GetTests());
    }
}