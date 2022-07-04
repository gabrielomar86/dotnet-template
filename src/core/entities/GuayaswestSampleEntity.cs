using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuayaswestSample.core.entities
{
    public class GuayaswestSampleEntity : EntidadBase<Guid>
    {
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Descripcion { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Valor { get; set; }

    }
}