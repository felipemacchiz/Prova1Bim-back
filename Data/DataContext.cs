using Prova1Bim_back.Models;
using Microsoft.EntityFrameworkCore;

namespace Prova1Bim_back.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Automovel> Automoveis { get; set; }
    }
}