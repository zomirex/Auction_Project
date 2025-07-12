using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionContext.Domain.Common.BaseClasses
{
    public abstract class BaseEntity : IComparable<BaseEntity>
    {
        public  long Id { get; set; }
        public bool IsDelete { get; protected set; } = false;
        public DateTime? DeleteTime { get; set; } = null;
        public int CompareTo(BaseEntity? other)
        {

            if (Id == other.Id) return 0;
            else if (Id > other.Id) return 1;
            return -1;

        }
    }
}
