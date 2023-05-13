using Microsoft.EntityFrameworkCore;
using Roaming.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Interfaces
{
    public interface IRoamingDbContext
    {
        DbSet<Counterparty> Counterparties { get; set; }
        DbSet<File> Files { get; set; }
        DbSet<Document> Documents { get; set; }
        DbSet<Partnership> Partnerships { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
