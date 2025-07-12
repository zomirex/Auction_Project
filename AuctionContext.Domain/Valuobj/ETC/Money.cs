using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuctionContext.Domain.Common.BaseClasses;
using AuctionContext.Domain.Common.Enums;
namespace AuctionContext.Domain.Valuobj.ETC
{
    public class Money : ValueObj, IComparable<Money>
    {
        public decimal Amount { get; private set; }
        public MoneyType MoneyType { get; set; }
        public int CompareTo(Money? other)
        {
            if (other.Amount > Amount) return -1; // null is considered less than any Money instance
            else if (other.Amount ==Amount ) return 0; // null is considered less than any Money instance
            else return 1; // null is considered less than any Money instance
        }
        public bool ensureMoneyType(MoneyType moneyType)
        {
            return MoneyType == moneyType;
        }
        public static bool operator >(Money a, Money b)
        {
            return a.Amount > b.Amount ;
        }
        public static bool operator <(Money a, Money b)
        {
            return a.Amount < b.Amount;
        }
        public static bool operator ==(Money a, Money b)
        {
            return a.Amount == b.Amount;
        }
        public static bool operator !=(Money a, Money b)
        {
            return a.Amount != b.Amount;
        }
        public static Money operator +(Money a, Money b)
        {
            return new Money { Amount = a.Amount +b.Amount };
        }
        public static Money operator -(Money a, Money b)
        {
            return new Money { Amount = a.Amount - b.Amount };
        }
    }
}
