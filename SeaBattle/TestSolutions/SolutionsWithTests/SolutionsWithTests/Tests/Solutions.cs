namespace SolutionsWithTests.Tests;

using TestManager.Attributes;
using System.Text;


public class Solutions
{
	private LocalTestTasks task = LocalTestTasks.AddTask(File.ReadAllLines("../../../Tests/test1.txt"));

	[MethodTesting]
	public void QueueMethod()
	{
		StringBuilder result = new StringBuilder();

		for (int i = 0; i < task.CountLines; i++)
		{
			int[] testNumbers = task.Lines.ToArray()[i]
				.Split(' ').Select(x => int.Parse(x)).ToArray();

			PriorityQueue<int, int> queue = new PriorityQueue<int, int>();

			for (int j = 0; j < testNumbers.Length; j++)
			{
				queue.Enqueue(testNumbers[j], testNumbers[j]);
			}


			bool isTrue = true;

			for (int j = 0; j < 4; j++)
			{
				if (queue.Dequeue() != 1)
				{
					isTrue = false;
					break;
				}
			}

			if (isTrue == false)
			{
				result.Append("no\n");
				continue;
			}

			for (int j = 0; j < 3; j++)
			{
				if (queue.Dequeue() != 2)
				{
					isTrue = false;
					break;
				}
			}

			if (isTrue == false)
			{
				result.Append("no\n");
				continue;
			}

			for (int j = 0; j < 2; j++)
			{
				if (queue.Dequeue() != 3)
				{
					isTrue = false;
					break;
				}
			}

			if (isTrue == false)
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
	}

	[MethodTesting]
	public string HashMapMethod()
	{
		StringBuilder result = new StringBuilder();

		for (int i = 0; i < task.CountLines; i++)
		{
			int[] testNumbers = task.Lines.ToArray()[i]
				.Split(' ').Select(x => int.Parse(x)).ToArray();

			Dictionary<int, int> map = new Dictionary<int, int>();

			for (int j = 0; j < testNumbers.Length; j++)
			{
				if (map.ContainsKey(testNumbers[j]))
				{
					map[testNumbers[j]]++;
				}
				else
				{
					map.Add(testNumbers[j], 1);
				}
			}

			if (map[4] != 1)
			{
				result.Append("no\n");
				continue;
			}
			if (map[3] != 2)
			{
				result.Append("no\n");
				continue;
			}
			if (map[2] != 3)
			{
				result.Append("no\n");
				continue;
			}
			if (map[1] != 4)
			{
				result.Append("no\n");
				continue;
			}

			result.Append("yes\n");
		}

		return result.ToString();
	}
}
