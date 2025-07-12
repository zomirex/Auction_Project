using AuctionContext.Domain.Common.Interfaces;
using AuctionContext.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionContext.Domain.Repositories
{
    public interface IAuctionRepository:IRepository
    {
        public long GettNextAuctionId();
        public Task AddAuction(Auction auction, CancellationToken token);
        public Task<Auction> GetAuctionId(long id);
        public Task UpdateAuction(Auction auction, CancellationToken token);
    }
}
