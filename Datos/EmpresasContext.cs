using System;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class EmpresasContext : DbContext
    {

        public EmpresasContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Empresas> Empresas { get; set; }
    }
}
