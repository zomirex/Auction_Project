using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionContext.Domain.Common.Enums
{
    public enum AuctionState
    {
        InProgress = 1,
        Finished = 2,
        Started = 3,
        Canceled = 4,
    }
}
