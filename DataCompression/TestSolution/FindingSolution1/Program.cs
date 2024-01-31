namespace FindingSolution1;

using System.Text;
using OzonTestsManager;


public class Program
{
    static void Main()
    {
        OzonTasksBuilder builder = 
                OzonTools.CreateBuilderWithBasicSettings(TaskSettings.IgnoreTitle, 
                        File.ReadAllLines("Task.txt"), File.ReadAllLines("Result.txt")
                    );

        OzonCurrentTest test = builder.Build();

        string[] task = test.ArrayTasks;
    }
}