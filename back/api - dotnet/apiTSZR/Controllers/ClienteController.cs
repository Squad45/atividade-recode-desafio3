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
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IMapper _mapper;
        public ClienteController(IClienteRepository clienteRepository, IEnderecoRepository enderecoRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
            _enderecoRepository = enderecoRepository;
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
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateClienteFisico([FromQuery]string cep, [FromQuery]string uf, [FromBody]ClienteDtoFisica clienteCreate)
        {
            var endereco = clienteCreate.Endereco;
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
            
            if(!_clienteRepository.CreateCliente(endereco, clienteMap))
            {
                ModelState.AddModelError("", "Ocorreu algo de errado ao salvar");
                return StatusCode(500, ModelState);
            }

            return Ok("Criado com sucesso!");
            

        }
        #endregion
        
    }
}