
using AutoMapper;
using GuayaswestSample.core.dto;
using GuayaswestSample.core.entities;
using GuayaswestSample.core.extensiones;
using GuayaswestSample.core.interfaces.contratos;
using GuayaswestSample.core.interfaces.contratos.servicios;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Xunit;

namespace GuayaswestSample.services.test
{
    public class GuayaswestSampleServicioTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IRepositorioWrapper> _mockRepositorioWrapper;

        public GuayaswestSampleServicioTest()
        {
            _mapper = new MapperConfiguration(opts => { opts.AddProfile(typeof(GuayaswestSampleMappingProfile)); }).CreateMapper();
            _mockRepositorioWrapper = new Mock<IRepositorioWrapper>();
        }

        [Fact]
        public void Should_ObtenerPorId()
        {
            // Arrange
            var GuayaswestSampleServicio = ObtenerGuayaswestSampleServicio();
            _mockRepositorioWrapper
                .Setup(mrw => mrw.GuayaswestSampleRepositorio.BuscarPorCondicion(It.IsAny<Expression<Func<GuayaswestSampleEntity, bool>>>()))
                .Returns(ObtenerEntidadesQueryable());

            // Act
            var resultado = GuayaswestSampleServicio.ObtenerPorId(It.IsAny<Guid>());

            // Assert
            Assert.IsType<GuayaswestSampleDto>(resultado);
            _mockRepositorioWrapper
                .Verify(mrw => mrw.GuayaswestSampleRepositorio.BuscarPorCondicion(It.IsAny<Expression<Func<GuayaswestSampleEntity, bool>>>()), Times.Once);
        }

        [Fact]
        public void Should_ObtenerTodos()
        {
            // Arrange
            var GuayaswestSampleServicio = ObtenerGuayaswestSampleServicio();
            _mockRepositorioWrapper
                .Setup(mrw => mrw.GuayaswestSampleRepositorio.ObtenerTodo())
                .Returns(ObtenerEntidadesQueryable());

            // Act
            var resultado = GuayaswestSampleServicio.ObtenerTodos();

            // Assert
            Assert.IsType<List<GuayaswestSampleDto>>(resultado);
            Assert.Single(resultado);
            _mockRepositorioWrapper
                .Verify(mrw => mrw.GuayaswestSampleRepositorio.ObtenerTodo(), Times.Once);
        }

        #region Private Methods

        private IGuayaswestSampleServicio ObtenerGuayaswestSampleServicio()
        {
            return new GuayaswestSampleServicio(_mapper, _mockRepositorioWrapper.Object);
        }

        private IQueryable<GuayaswestSampleEntity> ObtenerEntidadesQueryable()
        {
            var listado = new List<GuayaswestSampleEntity>
            {
                new GuayaswestSampleEntity()
            };

            return listado.AsQueryable();
        }
        #endregion
    }
}
