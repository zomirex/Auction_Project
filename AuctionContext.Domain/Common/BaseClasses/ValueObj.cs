using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionContext.Domain.Common.BaseClasses
{
    public abstract class ValueObj
    {
        protected static bool EqualOperator(ValueObj left, ValueObj right)
        {
            if (left is null ^ right is null)
                return false;
            else
                return left?.Equals(right!) != false;
        }
        protected static bool NotEqualOperator(ValueObj left, ValueObj right)
        {
            return !EqualOperator(left, right);
        }
    }
}
