using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace Kamak.Core.Service
{
    public class AuthenticationServiceTests
    {
        [Fact]
        public void ShouldReturnSuccessIfCredentialsProvided()
        {
            //Arrange
            var request = new UserCredential
            {
                Username = "melody.sunshin@permit.com",
                Password = "Password123!"
            };

            var processor = new AuthenticationService();

            //Act
            UserCredentialResponse response = processor.Login(request);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(request.Username, response.Username);
            Assert.Equal(request.Password, response.Password);
        }

        [Fact]
        public void ThrowsNullExceptionIfNoCredentials()
        {
            //Arrange
            var processor = new AuthenticationService();

            //Act
            var exeception = Assert.Throws<ArgumentNullException>(() => processor.Login(null));

            //Assert
            Assert.Equal("request", exeception.ParamName);

        }
    }
}
