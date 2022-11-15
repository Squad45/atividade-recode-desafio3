using System.Net.Mime;
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
    public class EnderecoController : Controller
    {
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IMapper _mapper;
        public EnderecoController(IEnderecoRepository enderecoRepository, IMapper mapper)
        {
            _enderecoRepository = enderecoRepository;
            _mapper = mapper;
        }

         [HttpGet]
         [ProducesResponseType(200, Type = typeof(IEnumerable<Endereco>))]
         public IActionResult GetEnderecos(){
            var endereco = _mapper.Map<List<EnderecoDto>>(_enderecoRepository.GetEnderecos());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
                
            return Ok(endereco);

         }
    }
}