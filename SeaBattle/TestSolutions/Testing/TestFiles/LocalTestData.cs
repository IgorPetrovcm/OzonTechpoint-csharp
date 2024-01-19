namespace Testing.TestFiles;

using System.Text.RegularExpressions;


public class LocalTestData : ILocalTest
{
    private readonly int? _countLine;

    private readonly IEnumerable<string>? _lines;

    public int? CountLine { 
        get => _countLine;
    }

    public IEnumerable<string>? Lines {
        get => _lines;
    }

    public LocalTestData(int countLine,IEnumerable<string> lines)
    {
        _countLine = countLine;
        _lines = lines;
    }

    public static LocalTestData GetTests(string path)
    {
        int countLine = 0;

        IList<string> lines = new List<string>(); 

        try
        {
            StreamReader reader = new StreamReader(path);

            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                if (Regex.Match(line, @"^\d\n",RegexOptions.None) != null)
                {
                    countLine = int.Parse(line);
                    continue;
                }

                lines.Add(line);
            }
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }

        return new LocalTestData(countLine, lines);
        
    }
}