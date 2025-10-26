using IUnitOfWorkVH.Implementations;
using Microsoft.Extensions.Logging;
using WebApiWithPostgreSQL.DB.Interfaces;

namespace WebApiWithPostgreSQL.DB.Implementations
{
    public class UnitOfWork : UnitOfWorkBaseAbstract<AppDbCtx>, IUnitOfWork
    {
        public IRepUsers RepUsers { get; }

        public UnitOfWork(AppDbCtx ctx, ILogger<AppDbCtx> logger)
        {
            this._logger = logger;
            this._ctx = ctx;
            RepUsers = new RepUsers(this._ctx);
        }
    }
}
