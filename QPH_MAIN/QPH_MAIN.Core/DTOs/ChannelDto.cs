using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QPH_MAIN.Core.DTOs
{
    public class ChannelDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo fecha es obligatorio")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage="El campo enlace es obligatorio")]
        public string Enlace { get; set; }

        [Required(ErrorMessage = "El campo Segmento es obligatorio")]
        public string Segmento { get; set; }

        [Required(ErrorMessage = "El campo PuntoEmision es obligatorio")] 
        public string PuntoEmision { get; set; }
        [Required(ErrorMessage = "El campo Ambiente es obligatorio")] 
        public string Ambiente { get; set; }
        [Required(ErrorMessage = "El campo Iva es obligatorio")] 
        public double Iva { get; set; }
        [Required(ErrorMessage = "El campo CodigoProducto es obligatorio")] 
        public string CodigoProducto { get; set; }
        [Required(ErrorMessage = "El campo NombreProducto es obligatorio")] 
        public string NombreProducto { get; set; }
        [Required(ErrorMessage = "El campo CategoriaCliente es obligatorio")] 
        public string CategoriaCliente { get; set; }
        [Required(ErrorMessage = "El campo CuentaContable es obligatorio")] 
        public string CuentaContable { get; set; }
        [Required(ErrorMessage = "El campo GrupoCredito es obligatorio")] 
        public string GrupoCredito { get; set; }
        [Required(ErrorMessage = "El campo DocumentoElectronico es obligatorio")] 
        public string DocumentoElectronico { get; set; }
        [Required(ErrorMessage = "El campo Relacionado es obligatorio")] 
        public string Relacionado { get; set; }
        [Required(ErrorMessage = "El campo VendorSeccion es obligatorio")] 
        public string VendorSeccion { get; set; }
        [Required(ErrorMessage = "El campo ListaPrecioContado es obligatorio")] 
        public string ListaPrecioContado { get; set; }
        [Required(ErrorMessage = "El campo ListaPrecioCredito es obligatorio")] 
        public string ListaPrecioCredito { get; set; }
        [Required(ErrorMessage = "El campo LimiteCredito es obligatorio")] 
        public string LimiteCredito { get; set; }
        [Required(ErrorMessage = "El campo Uge es obligatorio")] 
        public string Uge { get; set; }
        [Required(ErrorMessage = "El campo Bodega es obligatorio")] 
        public string Bodega { get; set; }
        [Required(ErrorMessage = "El campo FormaPago es obligatorio")] 
        public string FormaPago { get; set; }
        [Required(ErrorMessage = "El campo Status es obligatorio")] 
        public string Status { get; set; }
    }
}
