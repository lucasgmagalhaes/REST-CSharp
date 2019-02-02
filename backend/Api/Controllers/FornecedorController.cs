using Entidades.Entidades.App;
using Microsoft.AspNetCore.Mvc;
using Persistencia.Interfaces;
using System;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class FornecedorController : ApiControllerBase<Fornecedor>
    {
        private readonly IFornecedorService fornecedorService;

        public FornecedorController(IFornecedorService fornecedorService)
        {
            this.fornecedorService = fornecedorService;
        }

        public override IActionResult Delete(long id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public override IActionResult Get()
        {
            try
            {
                List<Fornecedor> fornecedores = this.fornecedorService.Buscar();
                return Ok(fornecedores);
            }
            catch
            {
                return BadRequest();
            }
        }

        public override IActionResult Get(long id)
        {
            throw new NotImplementedException();
        }

        public override IActionResult Post([FromBody] Fornecedor entidade)
        {
            throw new NotImplementedException();
        }

        public override IActionResult Put([FromBody] Fornecedor entity)
        {
            throw new NotImplementedException();
        }
    }
}
