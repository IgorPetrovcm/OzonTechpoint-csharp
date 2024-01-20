namespace SolutionsWithTest;

using TestManager;

public class Program
{
    static void Main()
    {
        TestBuilder test = new TestBuilder(typeof(Tests));

        System.Console.WriteLine(test.GetTests());
    }
}