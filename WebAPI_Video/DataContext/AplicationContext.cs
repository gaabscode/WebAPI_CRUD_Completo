using Microsoft.EntityFrameworkCore;
using WebAPI_Video.Models;

namespace WebAPI_Video.DataContext
{
    public class AplicationContext : DbContext
    {

        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options) { }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
