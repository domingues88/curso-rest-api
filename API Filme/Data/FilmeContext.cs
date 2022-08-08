using API_Filme.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Filme.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
        {
        }
        public DbSet<Filme> Filmes { get; set; }
    }
}
