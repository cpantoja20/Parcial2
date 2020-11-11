using System;
using Entity;

namespace CreditosPymes.Models
{
    public class EmpresasInputModals
    {
         public string IdEmpresa { get; set; }
        public string NEmpresa { get; set; }
        public int CEmpleados { get; set; }
        public decimal VrActivos { get; set; }
        public decimal TipoEmpresa { get; set;}
        public decimal CreditoEmpresa { get; set;}
    }

    public class EmpresasViewModel : EmpresasInputModel
    {
        public EmpresasViewModel()
        {

        }
        public EmpresasViewModel(Empresas empresa)
        {
            IdEmpresa = empresa.IdEmpresa;
            NEmpresa = empresa.Nombre;
            CEmpleados = empresa.CEmpleados ;
            VrActivos  = empresa.VrActivos;
            TipoEmpresa = empresa.TipoEmpresa;
           CreditoEmpresa = empresa.CreditoEmpresa;
        }
        
  }
}