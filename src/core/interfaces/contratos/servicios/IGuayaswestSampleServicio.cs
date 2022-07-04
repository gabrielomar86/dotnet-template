using System;
using System.Collections.Generic;
using GuayaswestSample.core.dto;

namespace GuayaswestSample.core.interfaces.contratos.servicios
{
    public interface IGuayaswestSampleServicio
    {
        GuayaswestSampleDto ObtenerPorId(Guid id);
        List<GuayaswestSampleDto> ObtenerTodos();
    }
}