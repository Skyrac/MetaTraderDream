using Database.Utils.Extensions;

namespace MetaTraderDream.Api.Configurations
{
    public static class DatabaseConfigurations
    {
        public static void InitDatabases(this WebApplicationBuilder builder)
        {
            CreateDatabaseContext(builder);
        }
        private static void CreateDatabaseContext(WebApplicationBuilder builder)
        {
            //builder.Services.AddDatabaseContext<BaseMigration>(builder.Configuration);
            //builder.Services.AddPersistence<UserDatabaseContext, IUserUnitOfWork, UserUnitOfWork>(builder.Configuration);
        }
    }
}
