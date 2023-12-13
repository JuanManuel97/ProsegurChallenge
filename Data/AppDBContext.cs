using Microsoft.EntityFrameworkCore;

namespace ProsegurChallenge.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
    }
}
