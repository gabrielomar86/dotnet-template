using GuayaswestSample.core.dto;
using GuayaswestSample.core.interfaces.contratos;
using GuayaswestSample.core.interfaces.contratos.servicios;
using System;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;

namespace GuayaswestSample.services
{
    public class GuayaswestSampleServicio : IGuayaswestSampleServicio
    {
        private readonly IMapper _mapper;
        private readonly IRepositorioWrapper _repositorioWrapper;

        public GuayaswestSampleServicio(IMapper mapper,
                                        IRepositorioWrapper repositorioWrapper)
        {
            _mapper = mapper;
            _repositorioWrapper = repositorioWrapper;
        }

        public GuayaswestSampleDto ObtenerPorId(Guid id)
        {
            var entity = _repositorioWrapper
                .GuayaswestSampleRepositorio
                .BuscarPorCondicion(smp => smp.Id == id)
                .FirstOrDefault();
            return _mapper.Map<GuayaswestSampleDto>(entity);
        }

        public List<GuayaswestSampleDto> ObtenerTodos()
        {
            var entities = _repositorioWrapper.GuayaswestSampleRepositorio.ObtenerTodo();
            return _mapper.Map<List<GuayaswestSampleDto>>(entities);
        }

    }
}