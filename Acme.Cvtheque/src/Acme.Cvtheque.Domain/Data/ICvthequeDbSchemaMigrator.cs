using System.Threading.Tasks;

namespace Acme.Cvtheque.Data;

public interface ICvthequeDbSchemaMigrator
{
    Task MigrateAsync();
}
