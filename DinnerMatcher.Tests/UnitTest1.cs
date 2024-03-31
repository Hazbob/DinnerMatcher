

using System.Diagnostics;
using DinnerMatcherNew;
using DinnerMatcherNew.Controllers;
using DinnerMatcherNew.Models;
using DinnerMatcherNew.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace DinnerMatcher.Tests;

public class UnitTest1
{
    [Fact]
    public async void GivenUserDetails_CreatesNewUser()
    {
        //arrange
        var repositoryMock = new Mock<IUserRepository>();
        var httpContextAccessorMock = new HttpContextAccessor();
        var mockRequest = new CreateUserRequest()
        {
            Username ="test1",
            Email = "test2",
            Password = "test3"
        };

        repositoryMock.Setup(r => r.CreateUserAsync("test1", "test2", "test3"))
            .ReturnsAsync(new User()
            {
                Username ="test1",
                Email = "test2",
                Password = "test3"
            });
        
        var userController = new UserController(httpContextAccessorMock, repositoryMock.Object);
        //act
        var user = await userController.AddUserToDbTask(mockRequest);
        var okResult = user as OkObjectResult;
        //assert
        Assert.IsType<OkObjectResult>(user);
        Assert.NotNull(okResult);
        Assert.Equal(200, okResult.StatusCode);
    }
}