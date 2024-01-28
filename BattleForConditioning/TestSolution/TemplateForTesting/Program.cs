namespace TemplateForTesting;

using OzonTestsManager;

public class Program
{
    static void Main()
    {
        OzonCurrentTest test = OzonTools.CompleteCreation(File.ReadAllLines("../../../Task.txt"), File.ReadAllLines("../../../Result.txt"));

        for (int i = 0; i < test.TaskCount; i++)
        {
            string[] task = test.ArrayTasks;

            for (int j = 0; j < task.Length; j++)
            {
                for (int h = 0; h < int.Parse(task[j]); h++)
                {
                    j++;

                    //Работаем с каждым элементом 'i' набора в интервале от: task[j++], пока h меньше значнеия указанного в task[j]
                    //Допусти:
                    /*
                        4 (i)
                        4 (j) => начинаеться цикл с индексом 'h', пока он меньшезначения в 'j'
                        операций в цикле будет 4, с каждой операцией 'j' инкрементируеться и мы получаем значнеия дальше
                        <= 1 (j + 1)        h++ = 1
                        <= 1 (j + 2)        h++ = 2
                        >= 5 (j + 3)        h++ = 3
                        >= 5 (j + 4) => последняя операция, так как далее 'h' равняеться 4, то есть изначально 'j'

                    */  
                }
            }
        }
    }
}