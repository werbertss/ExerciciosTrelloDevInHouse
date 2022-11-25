using System.Diagnostics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;

namespace Escola.Api.Controllers.V2
{
    [Controller]
    [Route("api/v2/materia")]
    public class MateriaV2Controller : ControllerBase
    {
        private readonly IMateriaServico _materiaServico;
        public MateriaV2Controller(IMateriaServico materiaServico)
        {
            _materiaServico = materiaServico;
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            return Ok(_materiaServico.ObterTodos().Select(x => new MateriaV2DTO(x)));
        }
    }

    
}
