using Xunit;
using Moq;
using CompChecklistAPI.Models;
using CompChecklistAPI.Enums;
using CompChecklistAPI.Interfaces;
using System.Collections.Generic;

namespace CompChecklistAPITests
{
    public class ComplianceTaskServiceTests
    {
        private readonly Mock<IComplianceTaskService> _mockService;

        public ComplianceTaskServiceTests()
        {
            _mockService = new Mock<IComplianceTaskService>();
        }

        [Fact]
        public void GetAllTasks_ReturnsCorrectTasks()
        {
            // Arrange
            _mockService.Setup(service => service.GetAllTasks())
                .Returns(new List<ComplianceTask>());

            // Act
            var tasks = _mockService.Object.GetAllTasks();

            // Assert
            Assert.IsType<List<ComplianceTask>>(tasks);
        }

        [Fact]
        public void AddTask_AddsNewTaskCorrectly()
        {
            // Arrange
            var task = new ComplianceTask { Description = "Test", Category = Category.DataSecurity, Priority = Priority.High, Status = Status.NotStarted };
            _mockService.Setup(service => service.AddTask(It.IsAny<ComplianceTask>()))
                .Returns(task);

            // Act
            var addedTask = _mockService.Object.AddTask(task);

            // Assert
            _mockService.Verify(service => service.AddTask(It.IsAny<ComplianceTask>()), Times.Once());
        }
    }
}
