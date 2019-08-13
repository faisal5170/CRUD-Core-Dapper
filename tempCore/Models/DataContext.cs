using Microsoft.EntityFrameworkCore;

namespace tempCore.Models
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
