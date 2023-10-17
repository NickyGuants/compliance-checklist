using CompChecklistAPI.Enums;

namespace CompChecklistAPI.Models;

public static class SeedData
{
    public static List<ComplianceTask> Seed()
    {
        return new List<ComplianceTask>
        {
            new ComplianceTask { TaskID = 1, Category = Category.LaborLaws, Description = "Review HR policies", DueDate = DateTime.Now.AddDays(30), Priority = Priority.High, Status = Status.NotStarted },
            new ComplianceTask { TaskID = 2, Category = Category.HealthSafetyEnvironmental, Description = "Inspect fire safety measures", DueDate = DateTime.Now.AddDays(10), Priority = Priority.Medium, Status = Status.InProgress },
            new ComplianceTask { TaskID = 3, Category = Category.CorporateGovernance, Description = "Update registration paperwork", DueDate = DateTime.Now.AddDays(20), Priority = Priority.Low, Status = Status.NotStarted },
            new ComplianceTask { TaskID = 4, Category = Category.DataSecurity, Description = "Conduct data privacy training", DueDate = DateTime.Now.AddDays(15), Priority = Priority.High, Status = Status.Completed },
            new ComplianceTask { TaskID = 5, Category = Category.LaborLaws, Description = "Review employee contracts", DueDate = DateTime.Now.AddDays(5), Priority = Priority.High, Status = Status.InProgress },
            new ComplianceTask { TaskID = 6, Category = Category.HealthSafetyEnvironmental, Description = "Verify first aid kits", DueDate = DateTime.Now.AddDays(40), Priority = Priority.Medium, Status = Status.NotStarted },
            new ComplianceTask { TaskID = 7, Category = Category.CorporateGovernance, Description = "Review financial disclosures", DueDate = DateTime.Now.AddDays(50), Priority = Priority.Low, Status = Status.InProgress },
            new ComplianceTask { TaskID = 8, Category = Category.DataSecurity, Description = "Update firewall", DueDate = DateTime.Now.AddDays(25), Priority = Priority.High, Status = Status.NotStarted },
            new ComplianceTask { TaskID = 9, Category = Category.LaborLaws, Description = "Audit employee benefits", DueDate = DateTime.Now.AddDays(7), Priority = Priority.Medium, Status = Status.Completed },
            new ComplianceTask { TaskID = 10, Category = Category.HealthSafetyEnvironmental, Description = "Evaluate waste disposal", DueDate = DateTime.Now.AddDays(35), Priority = Priority.Medium, Status = Status.InProgress }
        };
    }
}

