namespace GuayaswestSample.core.interfaces.contratos
{
    public interface IRepositorioWrapper
    {
        /// <summary>
        /// Guayaswest Sample Repositorio
        /// </summary>
        IGuayaswestSampleRepositorio GuayaswestSampleRepositorio { get; }


        /// <summary>
        /// Guarda la accion en base de datos
        /// </summary>
        void Guardar();

        /// <summary>
        /// Inicia la transaccion
        /// </summary>
        void IniciarTransaccion();

        /// <summary>
        /// Confirma la transaccion
        /// </summary>
        void ConfirmarTransaccion();

        /// <summary>
        /// Revierte la transaccion
        /// </summary>
        void RevertirTransaccion();
    }
}