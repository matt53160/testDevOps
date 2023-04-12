using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.Cvtheque.Data;

/* This is used if database provider does't define
 * ICvthequeDbSchemaMigrator implementation.
 */
public class NullCvthequeDbSchemaMigrator : ICvthequeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
