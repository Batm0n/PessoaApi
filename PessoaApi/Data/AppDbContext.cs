using Microsoft.EntityFrameworkCore;
using PessoaApi.Models;

namespace AppDbContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Pessoa> Pessoas { get; set; }
}