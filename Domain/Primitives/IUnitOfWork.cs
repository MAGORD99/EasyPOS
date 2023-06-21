using ErrorOr;

namespace Domain.Primitives;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    Task<int> Update(Updated updatetoken = default);

}