using AttrakDiffResearch.Domain.Entities.Access;
using Microsoft.EntityFrameworkCore;


namespace AttrakDiffResearch.Infrastructure.Data.Context.Access
{
    internal class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
