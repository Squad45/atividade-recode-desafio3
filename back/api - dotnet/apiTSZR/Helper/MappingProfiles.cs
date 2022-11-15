using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTSZR.Dto;
using AutoMapper;

namespace apiTSZR.Helper
{
    public class MappingProfiles : Profile
    {
         public MappingProfiles()
        {
            CreateMap<Cliente, ClienteDtoFisica>();
            CreateMap<Cliente, ClienteDtoJuridica>();

            CreateMap<ClienteDtoFisica, Cliente>();
            CreateMap<ClienteDtoJuridica, Cliente>();

            CreateMap<Cliente, ClienteDto>();
            CreateMap<ClienteDto, Cliente>();

            CreateMap<Endereco, EnderecoDto>();
            CreateMap<EnderecoDto, Endereco>();
        }
    }
}