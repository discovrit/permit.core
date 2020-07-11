using Kamak.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamak.Core.Factory
{
    public class AuthenticationFactory
    {
        public UserCredential GetUserCredential() 
        {
            return BaseUserCredential();
        }

        private UserCredential BaseUserCredential()
        {
            return new UserCredential
            {
                Username = "melody.sunshin@permit.com",
                Password = "Password123!"
            };
        }
    }
}
