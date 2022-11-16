using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using apiTSZR.Dto;
using AutoMapper;

namespace apiTSZR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;
        public ClienteController(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        #region "METODOS GET"
         [HttpGet]
         [ProducesResponseType(200, Type = typeof(IEnumerable<Cliente>))]
         public IActionResult GetClientes(){
            var clientes = _mapper.Map<List<ClienteDto>>(_clienteRepository.GetClientes());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
                
            return Ok(clientes);

         }
         [HttpGet("fisico")]
         [ProducesResponseType(200, Type = typeof(IEnumerable<Cliente>))]
         public IActionResult GetClientesFisico(){
            var clientes = _mapper.Map<List<ClienteDtoFisica>>(_clienteRepository.GetClientes().Where(c=> c.Cpf != null).ToList());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
                
            return Ok(clientes);

         }
        [HttpGet("juridico")]
         [ProducesResponseType(200, Type = typeof(IEnumerable<Cliente>))]
         public IActionResult GetClientesJuridico(){
            var clientes = _mapper.Map<List<ClienteDtoJuridica>>(_clienteRepository.GetClientes().Where(c=> c.Cnpj != null).ToList());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
                
            return Ok(clientes);

         }
        [HttpGet("fisico/{cpf}")]
        [ProducesResponseType(200, Type = typeof(Cliente))]
        [ProducesResponseType(400)]
        public IActionResult GetClienteFisico(string cpf){
            if(!_clienteRepository.ClienteFisicoExist(cpf))
                return NotFound();
            
            var cliente = _mapper.Map<ClienteDtoFisica>(_clienteRepository.GetClienteByCPF(cpf));
            
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            return Ok(cliente);
        }
        [HttpGet("juridico/{cnpj}")]
        [ProducesResponseType(200, Type = typeof(Cliente))]
        [ProducesResponseType(400)]
        public IActionResult GetClienteJuridico(string cnpj){
            if(!_clienteRepository.ClienteJuridicoExist(cnpj))
                return NotFound();
            
            var cliente = _mapper.Map<ClienteDtoJuridica>(_clienteRepository.GetClienteByCNPJ(cnpj));
            
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            return Ok(cliente);
        }
        #endregion

        #region  "METODOS POST"
        [HttpPost("fisica")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateClienteFisico([FromBody]ClienteDtoFisica clienteCreate)
        {
            // tudo isso para previnir e/ou informar erros
            if(clienteCreate == null)
                return BadRequest(ModelState);

            var cliente = _clienteRepository.GetClientes()
                        .Where(c => c.Cpf == clienteCreate.Cpf).FirstOrDefault();

            if(cliente != null)
            {
                ModelState.AddModelError("", "cliente ja existente");
                return StatusCode(422, ModelState);
            }

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var clienteMap = _mapper.Map<Cliente>(clienteCreate);
            
            if(!_clienteRepository.CreateCliente(clienteMap))
            {
                ModelState.AddModelError("", "Ocorreu algo de errado ao salvar");
                return StatusCode(500, ModelState);
            }

            return Ok("Criado com sucesso!");
            

        }
        [HttpPost("juridica")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateClienteJuridica([FromBody]ClienteDtoJuridica clienteCreate)
        {
            // tudo isso para previnir e/ou informar erros
            if(clienteCreate == null)
                return BadRequest(ModelState);

            var cliente = _clienteRepository.GetClientes()
                        .Where(c => c.Cnpj == clienteCreate.Cnpj).FirstOrDefault();

            if(cliente != null)
            {
                ModelState.AddModelError("", "cliente ja existente");
                return StatusCode(422, ModelState);
            }

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var clienteMap = _mapper.Map<Cliente>(clienteCreate);
            
            if(!_clienteRepository.CreateCliente(clienteMap))
            {
                ModelState.AddModelError("", "Ocorreu algo de errado ao salvar");
                return StatusCode(500, ModelState);
            }

            return Ok("Criado com sucesso!");
            

        }
        #endregion

        #region  "METODOS UPDATE"
        [HttpPut("fisico/{cpf}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateClienteFisica(string cpf, [FromBody]ClienteDtoFisica updatedCliente)
        {
            if(updatedCliente == null)
                return BadRequest(ModelState);

            if(cpf != updatedCliente.Cpf)
                return BadRequest(ModelState);

            if(!_clienteRepository.ClienteFisicoExist(cpf))
                return NotFound();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var ClienteMap = _mapper.Map<Cliente>(updatedCliente);

            if(!_clienteRepository.UpdateCliente(ClienteMap))
            {
                ModelState.AddModelError("", "Algo de errado aconteceu ao tentar atualizar um Cliente");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }
        [HttpPut("juridico/{cnpj}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateClienteJuridica(string cnpj, [FromBody]ClienteDtoJuridica updatedCliente)
        {
            if(updatedCliente == null)
                return BadRequest(ModelState);

            if(cnpj != updatedCliente.Cnpj)
                return BadRequest(ModelState);

            if(!_clienteRepository.ClienteJuridicoExist(cnpj))
                return NotFound();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var ClienteMap = _mapper.Map<Cliente>(updatedCliente);

            if(!_clienteRepository.UpdateCliente(ClienteMap))
            {
                ModelState.AddModelError("", "Algo de errado aconteceu ao tentar atualizar um Cliente");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }
        #endregion   

        #region  "METODOS DELETE"
        [HttpDelete("{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteCliente(int id)
        {
            if(!_clienteRepository.ClienteExist(id))
                return NotFound();

            var ClienteToDelete = _clienteRepository.GetCliente(id);
            
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if(!_clienteRepository.DeleteCliente(ClienteToDelete))
            {
                ModelState.AddModelError("", "Algo de errado aconteceu ao tentar deletar uma promocão");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }
        [HttpDelete("{cpf}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteClienteFisica(string cpf)
        {
            if(!_clienteRepository.ClienteFisicoExist(cpf))
                return NotFound();

            var ClienteToDelete = _clienteRepository.GetClienteByCPF(cpf);
            
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if(!_clienteRepository.DeleteCliente(ClienteToDelete))
            {
                ModelState.AddModelError("", "Algo de errado aconteceu ao tentar deletar uma promocão");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }
        [HttpDelete("{cnpj}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteClienteJuridica(string cnpj)
        {
            if(!_clienteRepository.ClienteJuridicoExist(cnpj))
                return NotFound();

            var ClienteToDelete = _clienteRepository.GetClienteByCNPJ(cnpj);
            
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if(!_clienteRepository.DeleteCliente(ClienteToDelete))
            {
                ModelState.AddModelError("", "Algo de errado aconteceu ao tentar deletar uma promocão");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }
        #endregion
    }
}