using AuctionContext.Domain.Common.Interfaces;
using AuctionContext.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionContext.Domain.Repositories
{
    public  interface IItemRepository:IRepository
    {
        public long GettNextItemId();
        public Task AddItem(Item item, CancellationToken token);
        public Task<Item> GetItemId(long id);
        public Task UpdateItem( Item item, CancellationToken token);
    }
}
