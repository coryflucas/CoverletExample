using System;
using System.Threading.Tasks;
using Example;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Test
{
    public class ExampleTest
    {
        [Fact]
        public async Task TestSleep()
        {
            var options = new DbContextOptionsBuilder<ExampleContext>()
                .UseInMemoryDatabase("example")
                .Options;
            var context = new ExampleContext(options);
            var repo = new ExampleRepository(context);
            await repo.CountEntities();
        }
    }
}
