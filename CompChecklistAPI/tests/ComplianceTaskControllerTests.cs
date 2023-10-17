using Xunit;
using Moq;
using CompChecklistAPI.Controllers;
using CompChecklistAPI.Models;
using CompChecklistAPI.Enums;
using CompChecklistAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CompChecklistAPITests
{
    public class ComplianceTaskControllerTests
    {
        private readonly Mock<IComplianceTaskService> _mockService;
        private readonly ComplianceTaskController _controller;

        public ComplianceTaskControllerTests()
        {
            _mockService = new Mock<IComplianceTaskService>();
            _controller = new ComplianceTaskController(_mockService.Object);
        }

        [Fact]
        public void GetTasks_ReturnsOkResult()
        {
            var okResult = _controller.GetTasks();
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void AddTask_ReturnsCreatedAtAction()
        {
            var task = new ComplianceTask { Description = "Test", Category = Category.DataSecurity, Priority = Priority.High, Status = Status.NotStarted };

            _mockService.Setup(service => service.AddTask(It.IsAny<ComplianceTask>())).Returns(task);

            var createdResult = _controller.AddTask(task);
            Assert.IsType<CreatedAtActionResult>(createdResult.Result);
        }
    }
}
