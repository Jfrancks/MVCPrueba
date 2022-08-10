using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPrueba.Models
{
    public partial class Producto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("codigo")]
        [StringLength(10)]
        public string Codigo { get; set; }
        [StringLength(20)]
        public string NombreProducto { get; set; }
        public int? Precio { get; set; }
        [Column("cantidad")]
        public int? Cantidad { get; set; }
        [Column("tipo_id")]
        public int TipoId { get; set; }
        [Column("sucursal_id")]
        public int SucursalId { get; set; }

        [ForeignKey(nameof(SucursalId))]
        [InverseProperty("Producto")]
        public virtual Sucursal Sucursal { get; set; }
        [ForeignKey(nameof(TipoId))]
        [InverseProperty(nameof(TipoProducto.Producto))]
        public virtual TipoProducto Tipo { get; set; }
    }
}
