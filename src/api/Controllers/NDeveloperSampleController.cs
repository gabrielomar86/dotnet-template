using System;
using GuayaswestSample.core.interfaces.contratos.servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GuayaswestSample.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuayaswestSampleController : ControllerBase
    {
        private readonly IGuayaswestSampleServicio _GuayaswestSampleServicio;
        private readonly ILogger<GuayaswestSampleController> _logger;

        public GuayaswestSampleController(ILogger<GuayaswestSampleController> logger,
                                          IGuayaswestSampleServicio GuayaswestSampleServicio)
        {
            _logger = logger;
            _GuayaswestSampleServicio = GuayaswestSampleServicio;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_GuayaswestSampleServicio.ObtenerTodos());

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(Guid id) => Ok(_GuayaswestSampleServicio.ObtenerPorId(id));

    }
}
