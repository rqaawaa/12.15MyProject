using System.Threading.Tasks;

namespace Demo.Project.Data
{
    public interface IProjectDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
