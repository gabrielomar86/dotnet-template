using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuayaswestSample.core.entities
{
    /// <summary>
    /// Entidad base
    /// </summary>
    public class EntidadBase<TKey>
    {
        /// <summary>
        /// Identificador de la entidad
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TKey Id { get; set; }

        /// <summary>
        /// Fecha de creación del registro
        /// </summary>
        [Required]
        public DateTime FechaCreacionRegistro { get; set; }

        /// <summary>
        /// Indica si está o no
        /// </summary>
        [Required]
        [DefaultValue(true)]
        public bool Activo { get; set; } = true;
    }
}