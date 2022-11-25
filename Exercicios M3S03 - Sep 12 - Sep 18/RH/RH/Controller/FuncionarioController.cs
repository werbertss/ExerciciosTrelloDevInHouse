using Microsoft.AspNetCore.Mvc;
using RH.DTOs;
using RH.Repositories;

namespace RH.Controller
{
    [ApiController]
    [Route("[controller]")]

    public class FuncionarioController : ControllerBase
    {

        [HttpPost]
        public IActionResult CadastrarNovoFuncionario (CadastrarFuncionarioDto funcionario)
        {
            FuncionarioRepository.Adicionar(funcionario);

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarFuncionario(int id)
        {
            FuncionarioRepository.Excluir(id);
            return StatusCode(StatusCodes.Status204NoContent);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarGerente(int id)
        {
            FuncionarioRepository.Excluir(id);
            return StatusCode(StatusCodes.Status204NoContent);
        }

        [HttpGet]
        public IActionResult ListarFuncionarios()
        {
            return Ok(FuncionarioRepository.Obter());
        }
    }
}
