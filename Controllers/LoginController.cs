using M3P_BackEnd_Squad1.DTOs;
using M3P_BackEnd_Squad1.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace M3P_BackEnd_Squad1.Controllers
{
    [Route("[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly LoginService _service;

        public LoginController(LoginService loginService)
        {
            _service = loginService;
        }

        [HttpPost]
        public ActionResult Login([FromBody] LoginDTO login)
        {
            return Ok(_service.LoginValidation(login));
        }
    }
}