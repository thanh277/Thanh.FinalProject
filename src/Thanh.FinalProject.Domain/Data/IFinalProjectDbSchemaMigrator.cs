using System.Threading.Tasks;

namespace Thanh.FinalProject.Data
{
    public interface IFinalProjectDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
