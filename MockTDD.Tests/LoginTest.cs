using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using Moq;

namespace MockTDD.Tests
{
    [TestClass]
    public class LoginTest
    {
        private LoginService _loginService;

        [TestInitialize]
        public void Initialize()
        {
            var mockLoginRepository = new Mock<ILoginRepository>();
            mockLoginRepository.Setup(r => r.Login("user", "user")).Returns(true);
            mockLoginRepository.Setup(r => r.Login("wrong", "wrong")).Returns(false);

            this._loginService = new LoginService(mockLoginRepository.Object);
        }

        [TestMethod]
        public void ItCanLogin()
        {
            // Arrange
            string username = "user";
            string password = "user";
            bool expectated = true;

            // Act
            bool result = this._loginService.login(username, password);

            // Assert
            Assert.AreEqual(expectated, result);
        }

        [TestMethod]
        public void ItCantLoginWhenUserAndPasswordAreIncorrect()
        {
            // Arrange
            string username = "wrong";
            string password = "wrong";
            bool expectated = false;

            // Act
            bool result = this._loginService.login(username, password);

            // Assert
            Assert.AreEqual(expectated, result);
        }
    }
}
