using HomeTask_Lecture4.TaskSolutions;
using HomeTask_Lecture4.Utils;

public static class Program
{
    public static void Main(string[] args)
    {
        var firstTaskSolution = new FirstTaskSolution();
        firstTaskSolution.Resolve(Constants.Numbers.ToList());
    }
}