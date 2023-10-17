using CompChecklistAPI.Models;
using Microsoft.AspNetCore.Mvc;
using CompChecklistAPI.Services;
using CompChecklistAPI.Interfaces;

namespace CompChecklistAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ComplianceTaskController: ControllerBase
{
    private readonly IComplianceTaskService _complianceTaskService;

    public ComplianceTaskController(IComplianceTaskService complianceTaskService)
    {
        _complianceTaskService = complianceTaskService;
    }


    [HttpGet("tasks")]
    public ActionResult<IEnumerable<ComplianceTask>> GetTasks()
    {
        return Ok(_complianceTaskService.GetAllTasks());
    }

    [HttpPost("task")]
    public ActionResult<ComplianceTask> AddTask(ComplianceTask newTask)
    {
        try
        {
            if (newTask == null)
            {
                return BadRequest("Task is null");
            }

            var createdTask = _complianceTaskService.AddTask(newTask);
            return CreatedAtAction(nameof(GetTasks), new { id = createdTask.TaskID }, createdTask);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // This combines the results and sends them to frontend together instead of one by one.
    //TODO: Implement streaming to support displaying the results as each item's data processing is completed.
    [HttpGet("tasks/factorial")]
    public IActionResult CalculateFactorials()
    {
        try{
            var tasks = _complianceTaskService.GetAllTasks();

            //This is not thread safe, improvements to make it thread safe in case of database calls
            Parallel.ForEach(tasks, task =>
            {
                task.TaskIDFactorial = _complianceTaskService.CalculateFactorial(task.TaskID);
            });

            return Ok(tasks);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}