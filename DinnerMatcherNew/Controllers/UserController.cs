using System.Text;
using DinnerMatcherNew.Models;
using Microsoft.AspNetCore.Mvc;
using DinnerMatcherNew.Repositories;
namespace DinnerMatcherNew.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public IHttpContextAccessor RequestContext { get; private set; }
        
        public UserController(IHttpContextAccessor requestContext, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            RequestContext = requestContext;
        }
        //create a user POST
        [HttpPost("createuser")]
        public async Task<IActionResult> AddUserToDbTask([FromBody] CreateUserRequest request)
        {
            try
            {
                
                if (string.IsNullOrEmpty(request?.Username) || 
                    string.IsNullOrEmpty(request?.Email) || 
                    string.IsNullOrEmpty(request?.Password))
                {
                    return BadRequest("Must include username, email and password");
                }
                var newUser = await  _userRepository.CreateUserAsync(request.Username, request.Email, request.Password);
                
                return Ok(newUser);
                    
                
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error");
                throw;
            }
        }
    }
}