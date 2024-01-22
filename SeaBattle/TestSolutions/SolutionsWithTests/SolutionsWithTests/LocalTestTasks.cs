using System.Reflection.Metadata.Ecma335;
using TestManager.Attributes;

namespace SolutionsWithTests
{
	public class LocalTestTasks
	{
		private int _countLines;

		private IEnumerable<string> _lines;

		public int CountLines
		{
			get { return _countLines; }
		}

		public IEnumerable<string> Lines
		{
			get { return _lines; }
		}

		public LocalTestTasks(int countLines, IEnumerable<string> lines)
		{
			_countLines = countLines;
			_lines = lines;
		}

		public static LocalTestTasks AddTask(string[] allLines)
		{
			int count = int.Parse(allLines[0]);

			Span<string> lines = new Span<string>(allLines, 1, allLines.Length - 1);

			string[] taskLines = lines.ToArray();

			return new LocalTestTasks(count, taskLines);
		}
	}
}
