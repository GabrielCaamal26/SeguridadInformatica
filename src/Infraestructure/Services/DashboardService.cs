using ApplicationCore.Interfaces;
using ApplicationCore.Wrappers;
using Dapper;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
namespace Infraestructure.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ICurrentUserService _currentUserService;

        public DashboardService(ApplicationDbContext dbContext, ICurrentUserService currentUserService)
        {
            _dbContext = dbContext;
            _currentUserService = currentUserService;
        } 

        public async Task<Response<object>> GetData()
        {
            object list = new object();
            list = await _dbContext.users.ToListAsync();
            /// list = await (from s in _dbContext.users
            ///                select 

            return new Response<object>(list);
        }

    }
}
