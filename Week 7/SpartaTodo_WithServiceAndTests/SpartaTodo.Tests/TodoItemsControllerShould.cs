using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NuGet.Protocol;
using SpartaTodo.App.Controllers;
using SpartaTodo.App.Models;
using SpartaTodo.App.Models.ViewModels;
using SpartaTodo.App.Services;
using System.Security.Claims;
using System.Security.Principal;

namespace SpartaTodo.Tests
{
    internal class TodoItemsControllerShould
    {
        [Test]
        public void Index_WhenSuccessfulServiceResponse_ReturnsTodoItems()
        {
            var mockService = Mock.Of<ITodoService>();

            Mock
                .Get(mockService)
                .Setup(s => s.GetTodoItemsAsync(
                    It.IsAny<Spartan>(),
                    It.IsAny<string>(),
                    It.IsAny<string>()).Result)
                .Returns(GetTodoListServiceResponse());

            var sut = GetBasicSut(mockService);

            var result = sut.Index(null).Result;
            Assert.That(result, Is.InstanceOf<ViewResult>());

            var viewResult = result as ViewResult;
            var data = viewResult.Model;
            Assert.That(data, Is.InstanceOf<IEnumerable<TodoVM>>());
        }



        [Test]
        public void Index_WhenNotSuccessfulServiceResponse_ReturnsProblem()
        {
            var mockService = Mock.Of<ITodoService>();
            var response = GetFailedServiceResponse<IEnumerable<TodoVM>>("Fake problem message");
            
            Mock
                .Get(mockService)
                .Setup(s => s.GetTodoItemsAsync(
                    It.IsAny<Spartan>(),
                    It.IsAny<string>(),
                    It.IsAny<string>()).Result)
                .Returns(response);

            var sut = GetBasicSut(mockService);

            var result = sut.Index(null).Result;
            Assert.That(result, Is.InstanceOf<ObjectResult>());

            var objectResult = result as ObjectResult;
            var jsonString = result.ToJson();

            Assert.That(jsonString, Does.Contain("Fake problem"));
        }



        private ServiceResponse<T> GetFailedServiceResponse<T>(string message = "")
        {
            var response = new ServiceResponse<T>();
            response.Success = false;
            response.Message = message;
            return response;
        }



        private ServiceResponse<IEnumerable<TodoVM>> GetTodoListServiceResponse()
        {
            var response = new ServiceResponse<IEnumerable<TodoVM>>();
            response.Data = new List<TodoVM>
            {
                Mock.Of<TodoVM>(),
                Mock.Of<TodoVM>()
            };
            return response;
        }



        private TodoItemsController GetBasicSut(ITodoService mockService)
        {
            var mockUserManager = GetMockUserManager();
            var sut = new TodoItemsController(mockService, It.IsAny<IMapper>(), mockUserManager);
            
            sut.ControllerContext = new ControllerContext
            {
                HttpContext = GetMockHttpContext(GetMockClaimsPrincipal())
            };
            
            return sut;
        }



        private UserManager<Spartan> GetMockUserManager()
        {
            return new Mock<UserManager<Spartan>>(
                Mock.Of<IUserStore<Spartan>>(),
                null, null, null, null, null, null, null, null
            ).Object;
        }



        private ClaimsPrincipal GetMockClaimsPrincipal(string role = "Trainee", bool isInRole = false)
        {
            var identity = new GenericIdentity("FakeUserName", "");

            var mockPrincipal = Mock.Of<ClaimsPrincipal>();
            
            Mock
                .Get(mockPrincipal)
                .Setup(x => x.Identity)
                .Returns(identity);
            Mock
                .Get(mockPrincipal)
                .Setup(x => x.IsInRole(role))
                .Returns(isInRole);

            return mockPrincipal;
        }



        private HttpContext GetMockHttpContext(ClaimsPrincipal mockPrincipal)
        {
            var mockHttpContext = Mock.Of<HttpContext>();

            Mock
                .Get(mockHttpContext)
                .Setup(m => m.User)
                .Returns(mockPrincipal);

            return mockHttpContext;
        }
    }
}
