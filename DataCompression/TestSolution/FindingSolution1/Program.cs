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

            int pos = 0;

            for (int j = 1; j < int.Parse(task[i]); j++)
            {
                if (current == 0)
                {
                    if (Math.Abs(numbers[j] - numbers[j-1]) == 1)
                    {
                        current++;

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
                }
                else if (Math.Abs(numbers[j] - numbers[j-1]) == 1)
                {
                    if ((numbers[j] > numbers[j-1]) == isMore)
                    {
                        current++;
                    }
                    else
                    {
                        pos = numbers[j];


                        result.Append(pre + " " + pos);
                    }
                }
            }
        }
    }
}