using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Empresas
    {
        [Key]
        public string IdEmpresa { get; set; }
        public string NEmpresa { get; set; }
        public int CEmpleados { get; set; }
        public decimal VrActivos { get; set; }
        public string TipoEmpresa { get; set; }
        public string CreditoEmpresa { get; set; }
    }
 }
