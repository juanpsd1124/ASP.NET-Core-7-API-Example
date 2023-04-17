using API.Dtos;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

    public class UsuariosController : BaseApiController 
    {
        private readonly IUserService _userService;

        public UsuariosController(IUserService userService) {
        
            _userService = userService;
        
        }

        [HttpPost("register")]
        public async Task<ActionResult> RegisterAsync(RegisterDto model) { 
    
            var result = await _userService.RegisterAsync(model);
            return Ok(result);
        }

        [HttpPost("token")]
        public async Task<IActionResult> GetTokenAsync(LoginDto model) 
        { 
            var result = await _userService.GetTokenAsync(model);
            return Ok(result);
    
        }

    [HttpPost("addrole")]
    public async Task<IActionResult> AddRoleASync(AddRoleDto model)
    {

        var result = await _userService.AddRoleAsync(model);
        return Ok(result);
    }
}


