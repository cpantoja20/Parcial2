using System;
using Datos;
using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class EmpresasService
    {
        private readonly EmpresasContext _context;
        public EmpresasService(EmpresasContext context)
        {
            _context = context;

        }
    }
}
