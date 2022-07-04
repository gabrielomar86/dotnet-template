using GuayaswestSample.core.entities;
using GuayaswestSample.core.interfaces.contratos;

namespace GuayaswestSample.infrastructure.data
{
    public class GuayaswestSampleRepositorio : RepositorioGenerico<GuayaswestSampleEntity>, IGuayaswestSampleRepositorio
    {
        public GuayaswestSampleRepositorio(GuayaswestSampleContexto GuayaswestSampleContexto) : base(GuayaswestSampleContexto)
        {

        }
    }
}