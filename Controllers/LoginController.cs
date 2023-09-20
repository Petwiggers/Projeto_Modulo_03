using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.DTOs;
using M3P_BackEnd_Squad1.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
            if (!_service.Autenticar(login))
                return Unauthorized("Login ou Senha inválidos !");

            return Ok(_service.GerarToken(login));
        }
    }
}