namespace TemplateForTesting;

using OzonTestsManager;


public class Program
{
    static void Main()
    {
        //Так как привычный способ создания объекта текущего теста подразумевает инкапсуляцию значения количество наборов данных
        //в первой строке документа с заданием, то нам придеться использовать более гибкий способ создания 

        OzonTasksBuilder tasksBuilder = new OzonTasksBuilder();

        tasksBuilder.SetTask(TaskSettings.IgnoreTitle, File.ReadAllLines("Task.txt"));

        OzonCurrentTest test = tasksBuilder.Build();

        
    }
}