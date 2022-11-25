using Microsoft.AspNetCore.Mvc;
using RH.DTOs;
using RH.Repositories;
using RH.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;

namespace RH.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class AutenticacaoController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginDto dto)
        {
            var user = FuncionarioRepository.ObterPorUsuarioESenha(dto);

            if(user == null) return Unauthorized();

            var token = TokenService.GenerateTokenFromUser(user);
  
           var refreshToken = TokenService.GenerateRefreshToken();

            TokenService.SaveRefreshToken(user.Nome, refreshToken);

            return Ok(new
            {
                token,
                refreshToken
            });
        }

    }
}
