using CompChecklistAPI.Models;

namespace CompChecklistAPI.Interfaces;
public interface IComplianceTaskService
{
    List<ComplianceTask> GetAllTasks();
    ComplianceTask AddTask(ComplianceTask newTask);
    long CalculateFactorial(int TaskID);
}
