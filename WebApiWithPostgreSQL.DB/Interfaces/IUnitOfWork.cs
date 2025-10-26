using IUnitOfWorkVH.Interfaces;

namespace WebApiWithPostgreSQL.DB.Interfaces
{
    public interface IUnitOfWork : IUnitOfWorkBase
    {
        IRepUsers RepUsers { get; }
    }
}
