using PizzaWala.Application.Common.Interfaces.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaWala.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            //check if user already exist

            //create a user (generate unique id)
            Guid id = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(id, firstName, lastName);

            //create jwt
            return new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, token);
        }

        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult(Guid.NewGuid(), "firstName", "lastName", email, "token");
        }
    }
}
