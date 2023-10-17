using CompChecklistAPI.Models;
using CompChecklistAPI.Interfaces;

namespace CompChecklistAPI.Services;
public class ComplianceTaskService : IComplianceTaskService
{
    private static List<ComplianceTask> ComplianceTasks = new List<ComplianceTask>();

    public ComplianceTaskService()
    {
        if (!ComplianceTasks.Any())
        {
            ComplianceTasks = SeedData.Seed();
        }
    }

    public List<ComplianceTask> GetAllTasks()
    {
        return ComplianceTasks;
    }

    public ComplianceTask AddTask(ComplianceTask newTask)
    {
        newTask.TaskID = ComplianceTasks.Count + 1;
        ComplianceTasks.Add(newTask);
        return newTask;
    }

    public long CalculateFactorial(int n)
    {
        if (n == 0) return 1;
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
