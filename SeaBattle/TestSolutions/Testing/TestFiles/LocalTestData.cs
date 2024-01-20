namespace Testing.TestFiles;

using System.Text.RegularExpressions;


public class LocalTestData : ILocalTest
{
    private readonly int? _countLines;

    private readonly IEnumerable<string>? _lines;

    public int? CountLines { 
        get => _countLines;
    }

    public IEnumerable<string>? Lines {
        get => _lines;
    }

    public LocalTestData(int countLines,IEnumerable<string> lines)
    {
        _countLines = countLines;
        _lines = lines;
    }

    public static LocalTestData GetTest(string path)
    {
        int countLines = 0;

        IEnumerable<string> testsLines = default;

        try
        {
            string[] lines = File.ReadAllLines(path);

            countLines = int.Parse(lines[0]);

            Span<string> dynamicRes = new Span<string>(lines, 1, lines.Length - 1);

            testsLines = dynamicRes.ToArray(); 
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message + e.Source);
        }

        return new LocalTestData(countLines, testsLines); 
    }
}