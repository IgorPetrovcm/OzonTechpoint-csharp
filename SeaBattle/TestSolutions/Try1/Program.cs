using System.Text;

namespace SeaBattle.Try1;


public class Program
{
    static void Main()
    {
        int[] array = new int[10];

        StringBuilder result = new StringBuilder();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            PriorityQueue<int,int> queue = new PriorityQueue<int, int>();

            for (int j = 0; j < 10; j++)
            {
                queue.Enqueue(array[j],array[j]);
            }    

            bool currentRes = true;;

            for (int j = 0; j < 4; j++)        
            {
                if (queue.Dequeue() != 1)
                {
                    currentRes = false;
                    break;
                }
            }

            if (currentRes == false)
            {
                result.Append("no\n");

                continue;
            }

            for (int j = 0; j < 3; j++)
            {
                if (queue.Dequeue() != 2)
                {
                    currentRes = false;
                    break;
                }
            }
            
            if (currentRes == false)
            {
                result.Append("no\n");

                continue;
            }

            for (int j = 0; j < 2; j++)
            {
                if (queue.Dequeue() != 3)
                {
                    currentRes = false;
                    break;
                }
            }

            if (currentRes == false)
            {
                result.Append("no\n");

                continue;
            }

            if (queue.Dequeue() != 4)
            {
                result.Append("no\n");

                continue;
            }
            
            result.Append("yes\n");
        }
        System.Console.WriteLine(result.ToString());
    }
}