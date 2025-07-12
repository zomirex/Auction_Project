using AuctionContext.Domain.Common.Interfaces;
using AuctionContext.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionContext.Domain.Repositories
{
    public  interface IUserRepository:IRepository
    {
        public long GettNextUserId();
        public Task AddUser(User user, CancellationToken token);
        public Task<User> GetUserId(long id);
        public Task UpdateUser(User user, CancellationToken token);


    }
}
