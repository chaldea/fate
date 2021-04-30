using MongoDB.Driver;
using Chaldea.Fate.Template.Users;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Chaldea.Fate.Template.MongoDB
{
    [ConnectionStringName("Default")]
    public class TemplateMongoDbContext : AbpMongoDbContext
    {
        public IMongoCollection<AppUser> Users => Collection<AppUser>();

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.Entity<AppUser>(b =>
            {
                /* Sharing the same "AbpUsers" collection
                 * with the Identity module's IdentityUser class. */
                b.CollectionName = "AbpUsers";
            });
        }
    }
}
