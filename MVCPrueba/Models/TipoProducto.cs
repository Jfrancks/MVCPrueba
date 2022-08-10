using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPrueba.Models
{
    public partial class TipoProducto
    {
        public TipoProducto()
        {
            Producto = new HashSet<Producto>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(15)]
        public string DescripcionTipo { get; set; }

        [InverseProperty("Tipo")]
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
