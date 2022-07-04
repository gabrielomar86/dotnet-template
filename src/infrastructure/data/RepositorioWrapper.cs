using GuayaswestSample.core.interfaces.contratos;

namespace GuayaswestSample.infrastructure.data
{
    public class RepositorioWrapper : IRepositorioWrapper
    {
        private readonly GuayaswestSampleContexto _GuayaswestSampleContexto;
        private IGuayaswestSampleRepositorio _GuayaswestSampleRepositorio;

        public RepositorioWrapper(GuayaswestSampleContexto GuayaswestSampleContexto)
        {
            _GuayaswestSampleContexto = GuayaswestSampleContexto;
        }

        public IGuayaswestSampleRepositorio GuayaswestSampleRepositorio
        {
            get
            {
                if (_GuayaswestSampleRepositorio == null)
                {
                    _GuayaswestSampleRepositorio = new GuayaswestSampleRepositorio(_GuayaswestSampleContexto);
                }
                return _GuayaswestSampleRepositorio;
            }
        }

        public void ConfirmarTransaccion()
        {
            _GuayaswestSampleContexto.ConfirmarTransaccion();
        }

        public void Guardar()
        {
            _GuayaswestSampleContexto.SaveChanges();
        }

        public void IniciarTransaccion()
        {
            _GuayaswestSampleContexto.IniciarTransaccion();
        }

        public void RevertirTransaccion()
        {
            _GuayaswestSampleContexto.RevertirTransaccion();
        }
    }
}