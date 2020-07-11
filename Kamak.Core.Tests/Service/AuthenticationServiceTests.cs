using Kamak.Core.Factory;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace Kamak.Core.Service
{
    public class AuthenticationServiceTests
    {
        private readonly AuthenticationFactory _factory;
        private readonly AuthenticationService _service;

        public AuthenticationServiceTests()
        {
            _factory = new AuthenticationFactory();
            _service = new AuthenticationService();
        }

        [Fact]
        public void ShouldReturnSuccessIfCredentialsProvided()
        {
            //Arrange
            var request = _factory.GetUserCredential();

            //Act
            UserCredentialResponse response = _service.Login(request);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(request.Username, response.Username);
            Assert.Equal(request.Password, response.Password);
        }

        [Fact]
        public void ThrowsNullExceptionIfNoCredentials()
        {
            //Arrange

            //Act
            var exeception = Assert.Throws<ArgumentNullException>(() => _service.Login(null));

            //Assert
            Assert.Equal("request", exeception.ParamName);

        }
    }
}
