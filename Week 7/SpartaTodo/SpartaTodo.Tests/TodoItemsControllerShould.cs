using Castle.Core.Resource;
using Moq;
using SpartaTodo.App.Controllers;
using SpartaTodo.App.Models.ViewModels;
using SpartaTodo.App.Models;
using SpartaTodo.App.Services;
using Microsoft.AspNetCore.Mvc;
using SpartaTodo.App.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SpartaTodo.App;

namespace SpartaTodo.Tests
{
    public class Tests
    {
        private Mock<SpartaTodoContext> _contextMock;
        private IMapper _mapper;
        private ITodoService _service;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<SpartaTodoContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
            var context = new SpartaTodoContext(options);
            _contextMock = new Mock<SpartaTodoContext>(options);
            _mapper = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>())
                .CreateMapper();
            _service = new TodoService(context, _mapper);
        }

        [Category("Happy Path")]
        [Category("GetItems")]
        [Test]
        public async Task Index_WhenThereAreTodoItems_ReturnsListOfTodoVMs()
        {
            string filter = null;

            var todoVMs = new List<TodoVM>
            {
                new TodoVM { Id = 1, Title = "Task 1", Description = "Description 1" },
                new TodoVM { Id = 2, Title = "Task 2", Description = "Description 2" }
            };

            var controller = new TodoItemsController(_contextMock.Object, _mapper, _service);

            // Act
            var result = controller.Index(filter).Result;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result, Is.InstanceOf<IActionResult>());
        }


        [Category("Happy Path")]
        [Category("GetDetails")]
        [Test]
        public async Task Details_WhenGivenValidId_ReturnsTodoItemDetails()
        {
            string filter = null;

            var todoVMs = new List<TodoVM>
            {
                new TodoVM { Id = 1, Title = "Task 1", Description = "Description 1" },
                new TodoVM { Id = 2, Title = "Task 2", Description = "Description 2" }
            };

            var controller = new TodoItemsController(_contextMock.Object, _mapper, _service);

            // Act
            var result = controller.Details(1).Result;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result, Is.InstanceOf<IActionResult>());
        }
    }
}