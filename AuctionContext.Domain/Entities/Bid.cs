using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuctionContext.Domain.Common.BaseClasses;
using AuctionContext.Domain.Entity.Args;
using AuctionContext.Domain.Repositories;
using AuctionContext.Domain.Services;
using AuctionContext.Domain.Valuobj.Bid;
using AuctionContext.Domain.Valuobj.ETC;

namespace AuctionContext.Domain.Entity
{
    public class Bid : BaseEntity
    {
         public long AuctionId { get; set; }
        public  long BidderId { get; set; }
        public Money? Price { get; set; }
        public DateTime CreatedAt { get;  } = DateTime.Now;
        private Bid()
        {
            
        }
        private Bid(RigesterBid bid)
        {
            AuctionId = bid.AuctionId;
            BidderId = bid.BidderId;
            Price = bid.Price;
        }
        public async static Task<Bid> CreateAsync(RigesterBid bid,IBidServicecs servicecs)
        {
            return  new Bid(bid);
        }
    }
}                                                                                                                   
