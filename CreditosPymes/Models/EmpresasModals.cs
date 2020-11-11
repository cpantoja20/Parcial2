using System;
using Entity;

namespace CreditosPymes.Models
{
    public class EmpresasModals
    {
         public string IdEmpresa { get; set; }
        public string NEmpresa { get; set; }
        public int CEmpleados { get; set; }
        public decimal VrActivos { get; set; }
        public decimal TipoEmpresa { get; set;}
        public decimal CreditoEmpresa { get; set;}
    }

    public class EmpresaViewModel : EmpresaInputModel
    {
        public EmpresaViewModel()
        {

        }
        public EmpresaViewModel(Empresa empresa)
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