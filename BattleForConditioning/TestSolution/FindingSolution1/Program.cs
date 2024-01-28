namespace FindingSolution1;

using System.Text;
using OzonTestsManager;

public class Program
{
    static void Main()
    {
        int employeeGroupCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < employeeGroupCount; i++)
        {
            int employeeCount = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            bool tail = false;

            string firstRequirement = Console.ReadLine();

            int currentValue = int.Parse(firstRequirement[3].ToString() + firstRequirement[4].ToString());
            char currentRequirment = firstRequirement[0];

            result.Append(currentValue + "\n");

            for (int j = 1; j < employeeCount; j++)
            {
                string requirement = Console.ReadLine();

                if (tail == true)
                {
                    result.Append("-1\n");
                    continue;
                }

                int number = int.Parse(requirement[3].ToString() + requirement[4].ToString());

                if (currentRequirment == '>')
                {
                    if (number >= currentValue)
                    {
                        result.Append(currentValue + "\n");

                        if (requirement[0] == '>')
                            currentValue = number;
                            
                        currentRequirment = requirement[0];
                    }
                    else 
                    {
                        tail = true;

                        result.Append("-1\n");
                    }
                }
                else
                {
                    if (number <= currentValue)
                    {
                        result.Append(currentValue + "\n");

                        currentRequirment = requirement[0];
                    }
                    else 
                    {
                        tail = true;

                        result.Append("-1\n");
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}