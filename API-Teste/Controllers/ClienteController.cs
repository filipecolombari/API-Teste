using API_Teste.Data;
using API_Teste.DTO;
using API_Teste.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_Teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : BaseController
    {
        public ClienteController(APITesteContext context) : base(context)
        {
        }

        [HttpPost]
        public ActionResult Add([FromBody] ClienteDTO cliente)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] ClienteDTO cliente)
        {
            try
            {
                if (!_context.Clientes.Any(x => x.Id == id))
                    return BadRequest("Cliente não encontrado");

                var clienteModel = new Cliente()
                {
                    Id = id,
                    Nome = cliente.Nome,
                    Email = cliente.Email
                };

                _context.Update(clienteModel);

                return Ok($"Cliente ID: {id} foi atualizado com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Cliente> GetById(int? id)
        {
            if (id is null)
                return BadRequest("Informe um id");

            var cliente = _context.Clientes.Where(x => x.Id == id).FirstOrDefault();
            if (cliente is null)
                return Ok("Nenhum cliente encontrado");

            return Ok(cliente);
        }

        [HttpGet]
        public ActionResult<List<Cliente>> GetAll()
        {
            return Ok(_context.Clientes.ToList());
        }
    }
}
