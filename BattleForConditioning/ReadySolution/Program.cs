using System.Text;

namespace ReadySolution;


public class Program
{
    static void Main()
    {
        int countGroups = int.Parse(Console.ReadLine());

        for (int i = 0; i < countGroups; i++)
        {
            StringBuilder result = new StringBuilder();

            int countEmployees = int.Parse(Console.ReadLine());

            int[] interval = {15,30};
            bool isError = false;

            for (int j = 0; j < countEmployees; j++)
            {
                string requirement = Console.ReadLine();

                if (isError == true)
                {
                    result.Append("-1\n");

                    continue;
                }

                int number = int.Parse(requirement[3].ToString() + requirement[4].ToString());

                if (requirement[0] == '>')
                {
                    if (number > interval[0])
                        interval[0] = number;
                }
                else
                {
                    if (number < interval[1])
                        interval[1] = number;
                }

                if (interval[1] < interval[0])
                {
                    isError = true;

                    result.Append("-1\n");

                    continue;
                }

                result.Append(interval[0] + "\n");
            }
            
            Console.WriteLine(result.ToString());
        }
    }
}