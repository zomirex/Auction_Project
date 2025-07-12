using AuctionContext.Domain.Valuobj.Bid;
using AuctionContext.Domain.Valuobj.ETC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionContext.Domain.Entity.Args
{
    public class RigesterBid
    {
        public long AuctionId { get; set; }
        public long BidderId { get; set; }
        public Money Price { get; set; }
        



    }
}
