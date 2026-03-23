using HarnishBalanceSheetAi.Server.Controllers;
using HarnishBalanceSheetAi.Server.Models;
using HarnishBalanceSheetAi.Server.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;

namespace HarnishBalanceSheetAi.Server.Tests.Controllers;

[TestClass]
public class AuthControllerTests
{
    private Mock<IRepository> _mockRepository = null!;
    private Mock<IConfiguration> _mockConfiguration = null!;
    private AuthController _controller = null!;

    [TestInitialize]
    public void Setup()
    {
        _mockRepository = new Mock<IRepository>();
        _mockConfiguration = new Mock<IConfiguration>();
        _mockConfiguration.Setup(c => c["Jwt:Key"]).Returns("ThisIsASecretKeyForTestingPurposes123456!");
        _mockConfiguration.Setup(c => c["Jwt:Issuer"]).Returns("TestIssuer");
        _mockConfiguration.Setup(c => c["Jwt:Audience"]).Returns("TestAudience");
        _controller = new AuthController(_mockRepository.Object, _mockConfiguration.Object);
    }

    [TestMethod]
    public async Task Login_ValidCredentials_ReturnsOkWithToken()
    {
        var password = "TestPassword123";
        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
        var loginRequest = new LoginRequest
        {
            Email = "test@example.com",
            Password = password
        };

        _mockRepository.Setup(r => r.GetUser(loginRequest.Email))
            .ReturnsAsync(new User
            {
                UserId = 1,
                UserName = "TestUser",
                Email = loginRequest.Email,
                PasswordHash = hashedPassword
            });

        var result = await _controller.Login(loginRequest);

        Assert.IsNotNull(result);
        Assert.IsInstanceOfType<OkObjectResult>(result.Value);
    }

    [TestMethod]
    public async Task Login_UserNotFound_Returns401()
    {
        var loginRequest = new LoginRequest
        {
            Email = "notfound@example.com",
            Password = "TestPassword123"
        };

        _mockRepository.Setup(r => r.GetUser(loginRequest.Email))
            .ReturnsAsync((User)null!);

        var result = await _controller.Login(loginRequest);

        Assert.IsNotNull(result);
        Assert.AreEqual(401, result.StatusCode);
    }

    [TestMethod]
    public async Task Login_InvalidPassword_Returns401()
    {
        var loginRequest = new LoginRequest
        {
            Email = "test@example.com",
            Password = "TestPassword123"
        };

        var hashedPassword = BCrypt.Net.BCrypt.HashPassword("DifferentPassword456");

        _mockRepository.Setup(r => r.GetUser(loginRequest.Email))
            .ReturnsAsync(new User
            {
                UserId = 1,
                UserName = "TestUser",
                Email = loginRequest.Email,
                PasswordHash = hashedPassword
            });

        var result = await _controller.Login(loginRequest);

        Assert.IsNotNull(result);
        Assert.AreEqual(401, result.StatusCode);
    }
}
