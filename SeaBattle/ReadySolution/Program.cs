namespace ReadySolution;


public class Program
{
    static void Main()
    {
        int countLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < countLines; i++)
        {
            int[] numbers = Console.ReadLine()
                                .Split(' ').Select(x => int.Parse(x)).ToArray();

            int[] trueNumbers = {4,3,2,1};

            for (int j = 0; j < 10; j++)
            {
                trueNumbers[numbers[j] - 1]--;
            }

            bool isTrue = true;

            for (int j = 0; j < 4; j++)
            {
                if (trueNumbers[j] != 0)
                {
                    System.Console.WriteLine("no");

                    isTrue = false;

                    break;
                }
            }

            if (isTrue)
                System.Console.WriteLine("yes");
        }
    }
}