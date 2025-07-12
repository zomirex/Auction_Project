using AuctionContext.Domain.Common.Interfaces;
using AuctionContext.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionContext.Domain.Repositories
{
    public interface IBidRepository:IRepository
    {
        public long GettNextBidId();
        public Task AddBid(Bid bid, CancellationToken token);
        public Task<Bid> GetBidId(long id);
        public Task UpdateBid(Bid bid, CancellationToken token);
    }
}
