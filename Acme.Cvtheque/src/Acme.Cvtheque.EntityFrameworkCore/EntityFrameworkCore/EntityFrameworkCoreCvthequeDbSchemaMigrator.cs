using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.Cvtheque.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.Cvtheque.EntityFrameworkCore;

public class EntityFrameworkCoreCvthequeDbSchemaMigrator
    : ICvthequeDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCvthequeDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CvthequeDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CvthequeDbContext>()
            .Database
            .MigrateAsync();
    }
}
