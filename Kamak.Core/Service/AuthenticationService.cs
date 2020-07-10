using System;
using System.Collections.Generic;
using System.Text;

namespace Kamak.Core.Service
{
    public class AuthenticationService
    {
        public UserCredentialResponse Login(UserCredential request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            return new UserCredentialResponse
            {
                Password = request.Password,
                Username = request.Username
            };
        }
    }
}
