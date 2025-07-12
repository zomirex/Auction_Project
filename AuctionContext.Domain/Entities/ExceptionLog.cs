using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuctionContext.Domain.Common.BaseClasses;
using AuctionContext.Domain.Common.Enums;

namespace AuctionContext.Domain.Entity
{
    public class ExceptionLog : BaseEntity
    {
        public DateTime? ExcutedTime { get; set; }
        public EventType Eventtype { get; set; }
        public long AuctionId{ get; set; }
        public long? BidId { get; set; }

    }
}
