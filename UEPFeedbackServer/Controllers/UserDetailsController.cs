using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UEPFeedbackServer.Interfaces;
using UEPFeedbackServer.Models;

namespace UEPFeedbackServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UserDetailsController : ControllerBase
    {
        private IConfiguration _config;
        private IUserDetails userdetails;
        private IFeedbacks feedbacks;

        public UserDetailsController(IUserDetails repository, IConfiguration config, IFeedbacks connection)
        {
            userdetails = repository;
            _config = config;
            feedbacks = connection;
        }

        //GET: api/UserDetails
        [HttpGet]
        public ActionResult<IEnumerable<UserDetails>> GetUserDetails()
        {
            return userdetails.GetUserDetails();
        }

        [HttpGet]
        [Route("GetUser/name")]
        public UserDetails GetUser(string name)
        {
            return userdetails.GetUser(name);
        }

        [HttpPost]
        [Route("Login")]
        //POST: api/UserDetails/Login
        public IActionResult Login(UserDetails model)
        {
            if (model.Username == "Gnaneshwar" && model.Password == "123" || model.Username == "Poornima" && model.Password == "123")
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.UTF8.GetBytes("ThisismyPrivateSecretKey");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                     new Claim("username", model.Username.ToString()),
                     new Claim("password", model.Password.ToString()),
                    }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                return Ok(new { token });
            }
            else
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }
        }
    }
}
