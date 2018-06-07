using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Example
{
    public class ExampleRepository
    {
        private readonly ExampleContext _dbContext;

        public ExampleRepository(ExampleContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Entity> CountEntities()
        {
            return await _dbContext.Entities.FirstOrDefaultAsync();
        }
    }

    public class Entity
    {
        public int Id { get; set; }
    }

    public class ExampleContext : DbContext
    {
        public DbSet<Entity> Entities { get; set; }

        public ExampleContext(DbContextOptions<ExampleContext> options)
            : base(options)
        { }
    }
}