using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace ReadySolution;


public class Program 
{
    static void Main()
    {
        int taskCount = int.Parse(Console.ReadLine());

        string pattern = @"\D{1}\d{1,2}\D{2}";

        for (int i = 0; i < taskCount; i++)
        {
            string task = Console.ReadLine();

            string[] matchesLine = new string[task.Length / 4];

            int j = 0;

            foreach (Match match in Regex.Matches(task,pattern))
            {
                task = task.Replace(match.ToString(), "");

                matchesLine[j] = match.ToString();

                j++;
            }

            if (task.Length > 0)
                Console.WriteLine("-");
            else 
                Console.WriteLine(String.Join(" ", matchesLine));
        }
    }
}