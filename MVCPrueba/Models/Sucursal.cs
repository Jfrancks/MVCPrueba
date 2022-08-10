using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPrueba.Models
{
    public partial class Sucursal
    {
        public Sucursal()
        {
            Producto = new HashSet<Producto>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string NombreSucursal { get; set; }
        [StringLength(15)]
        public string Telefono { get; set; }
        [StringLength(50)]
        public string Direccion { get; set; }

        [InverseProperty("Sucursal")]
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
