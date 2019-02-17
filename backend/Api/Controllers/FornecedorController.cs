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
                if (fornecedores.Count > 0)
                {
                    return Ok(fornecedores);
                }
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        public override IActionResult Get(long id)
        {
            throw new NotImplementedException();
        }

        public override IActionResult Post([FromBody] Fornecedor entidade)
        {
            try
            {
                this.fornecedorService.Inserir(entidade);
                return Ok(entidade);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        public override IActionResult Put([FromBody] Fornecedor entity)
        {
            throw new NotImplementedException();
        }
    }
}
