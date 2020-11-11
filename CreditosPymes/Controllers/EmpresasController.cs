using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using CreditosPymes.Models;
using System;
using Datos;
using Logica;
using Entity;


namespace CreditosPymes.Controllers
{
    public class EmpresasController : ControllerBase
    {
        [Route("api/[Empresas]")]
        [ApiController]

        private readonly EmpresasService _empresasService;
        public EmpresasController(EmpresasContext context)
        {
            _empresasService = new EmpresasService(context);
        }
        [HttpGet]
        public IEnumerable<EmpresasViewModel> GetAll()
        {
            var empresas = _empresasService.ConsultarTodos().Select(p => new EmpresasViewModel(p));
            return empresas;
        }

        [HttpPost]
        public ActionResult<EmpresasViewModel> Post(EmpresasInputModel empresasInput)
        {
            Empresas empresas = MapearEmpresas(empresasInput);
            var response = _empresasService.Guardar(empresas);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Credito);
        }

        private Empresas MapearEmpresas(EmpresasInputModel empresasInput)
        {
            var empresas = new Empresas
            {
                IdEmpresa = empresaInput.IdEmpresa,
                NEmpresa = empresaInput.NEmpresa,
                CEmpleados = empresasInput.CEmpleados,
                VrActivos = empresasInput.VrActivos,
                TipoEmpresa = empresasInput.TipoEmpresa,
                CreditoEmpresa = empresasInput.CreditoEmpresa
            };
            return credito;

        }
    }
}
