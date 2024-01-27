namespace ReadySolution;


public class Program
{
    static void Main()
    {
        int countLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < countLines; i++)
        {
            int[] dateParams = Console.ReadLine()
                                    .Split(' ').Select(x => int.Parse(x)).ToArray();

            int daysInCurrentMonth = DateTime.DaysInMonth(dateParams[2], dateParams[1]);

            if (dateParams[0] > 0 && dateParams[0] <= daysInCurrentMonth)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}