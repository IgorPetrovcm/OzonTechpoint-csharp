namespace ReadySolution;


public class Program
{
    static void Main()
    {
        int countLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < countLines; i++)
        {
            ReadOnlySpan<char> dateParams = Console.ReadLine();

            DateTime isDate;

            if (DateTime.TryParse(dateParams, out isDate))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}