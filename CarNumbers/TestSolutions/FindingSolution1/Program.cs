using System.Text.RegularExpressions;
using System.Text;

namespace FinsingSolution1;


public class Program
{
    static void Main()
    {
        string task = "R48FAO00OOO0OOA99OKA99O";

        string pattern = @"\D{1}\d{1,2}\D{2}";

        string[] matchesLine = new string[task.Length / 4];

        int i = 0;

        foreach (Match match in Regex.Matches(task,pattern))
        {
            matchesLine[i] = match.ToString();
            i++;
        }

        if (String.Join("",matchesLine) != task)
            Console.WriteLine("-");
        else
            Console.WriteLine(String.Join(' ',matchesLine));
    }
}