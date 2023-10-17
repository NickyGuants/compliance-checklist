using CompChecklistAPI.Enums;

namespace CompChecklistAPI.Models;

public class ComplianceTask
{
    public int TaskID { get; set; }
    public long? TaskIDFactorial { get; set; }
    public Category Category { get; set; }
    public string? Description { get; set; }
    public DateTime DueDate { get; set; }
    public Priority Priority { get; set; }
    public Status Status { get; set; }
}