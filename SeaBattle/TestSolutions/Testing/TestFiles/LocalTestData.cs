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
        int countLine = 0;

        IList<string> lines = new List<string>(); 

        try
        {
            
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message + e.Source);
        }

        return new LocalTestData(countLine, lines);
        
    }
}