using IUnitOfWorkVH.Implementations;
using WebApiWithPostgreSQL.DB.Entities;
using WebApiWithPostgreSQL.DB.Interfaces;

namespace WebApiWithPostgreSQL.DB.Implementations
{
    public class RepUsers(AppDbCtx ctx) : Rep<AppDbCtx, User>(ctx), IRepUsers;
}
