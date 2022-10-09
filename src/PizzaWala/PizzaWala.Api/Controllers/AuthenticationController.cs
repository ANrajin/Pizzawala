using Microsoft.AspNetCore.Mvc;
using PizzaWala.Application.Services.Authentication;
using PizzaWala.Contracts.Authentication;

namespace PizzaWala.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var result = _authenticationService.Register(request.FirstName,
                request.LastName,
                request.Email,
                request.Password);

            var response = new AuthenticationResponse(result.Id,
                result.FirstName,
                result.LastName,
                result.Email,
                result.Token);

            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var result = _authenticationService.Login(request.Email, request.Password);

            var response = new AuthenticationResponse(result.Id,
                result.FirstName,
                result.LastName,
                result.Email,
                result.Token);

            return Ok(response);
        }
    }
}
