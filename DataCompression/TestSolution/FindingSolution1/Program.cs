namespace FindingSolution1;

using System.Text;
using OzonTestsManager;


public class Program
{
    static void Main()
    {
        OzonCurrentTest test = OzonTools.CompleteCreation(File.ReadAllLines("../../../Task.txt"), File.ReadAllLines("../../../Result.txt"));

        string[] task = test.ArrayTasks;

        for (int i = 0; i < task.Length; i++)
        {
            int[] numbers = task[i + 1]
                                .Split(' ').Select(x => int.Parse(x)).ToArray();

            StringBuilder result = new StringBuilder();

            int current = 0;

            bool isMore = false;

            int pre = 0;

            for (int j = 1; j < int.Parse(task[i]); j++)
            {
                if (current == 0)
                {
                    if (Math.Abs(numbers[j] - numbers[j-1]) == 1)
                    {
                        pre = numbers[j-1];

                        if (numbers[j] < numbers[j-1])
                        {
                            isMore = false;
                        }
                        else 
                        {
                            isMore = true;
                        }
                    }
                    else 
                    {
                        pre = numbers[j-1];

                        result.Append(pre + " " + "0 ");
                    }
                }
                if (Math.Abs(numbers[j] - numbers[j-1]) == 1)
                {
                    if ((numbers[j] > numbers[j-1]) == isMore)
                    {
                        current++;
                    }
                    else
                    {
                        result.Append(IsMoreResult(pre, current, isMore));

                        current = 0;
                    }
                }
                if (j == int.Parse(task[i]) - 1)
                {
                    result.Append(IsMoreResult(pre, current, isMore));

                    System.Console.WriteLine(result.ToString());
                }
            }

            i++;
        }

        string IsMoreResult(int pre, int current, bool isMore)
        {
            int pos = 0;

            if (isMore == true)
            {
                pos = current;
            }
            else
            {
                pos = -current;
            }

            return pre + " " + pos + " ";
        }
    }
}