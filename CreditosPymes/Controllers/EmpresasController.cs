
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Datos;
using System;

namespace CreditosPymes.Controllers
{
    public class EmpresasController
    {
        [Route("api/[Empresas]")]
        [ApiController]

        private readonly EmpresasService _empresasService;
        public EmpresasController(EmpresasContext context)
        {
            _empresasService = new EmpresasService(context);
        }
    }
}

