using Microsoft.EntityFrameworkCore;
using TshirtsManager.Data.Models;

namespace TshirtsManager.Data
{
    public class AppDbContext : DbContext 
    {
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

        public DbSet<Tshirt> Tshirt { get; set; }
    }
}
