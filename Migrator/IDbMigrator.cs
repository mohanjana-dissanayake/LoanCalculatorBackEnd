namespace Migrator
{
    public interface IDbMigrator
    {
        Task MigrateDbChanges();
    }
}
