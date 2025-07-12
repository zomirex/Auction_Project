using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuctionContext.Domain.Common.BaseClasses;
using AuctionContext.Domain.Valuobj.ETC;

namespace AuctionContext.Domain.Entity
{
    public class Item : BaseEntity
    {
        public string? Name { get; set; }
        public List<string> PhotosLink { get; set; }= new List<string>();
        public ItemDescription? Description { get; set; }
        public long AuctionID { get; set; }
    }
}
