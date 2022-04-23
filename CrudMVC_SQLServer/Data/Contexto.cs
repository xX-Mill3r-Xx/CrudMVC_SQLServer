using CrudMVC_SQLServer.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudMVC_SQLServer.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<CrudMVC_SQLServer.Models.Usuario> Usuario { get; set; }
    }
}
