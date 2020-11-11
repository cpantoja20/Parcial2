using Datos;

namespace CreditosPymes.Controllers
{
    public class EmpresasController
    {
        [Route("api/[controller]")]
        [ApiController]

        private readonly EmpresasService _empresasService;
        public EmpresasController(EmpresasContext context)
        {
            _empresasService = new EmpresasService(context);
        }
    }
}

