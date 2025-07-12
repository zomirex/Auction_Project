using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuctionContext.Domain.Common.BaseClasses;
using AuctionContext.Domain.Common.Enums;
using AuctionContext.Domain.Valuobj.User;

namespace AuctionContext.Domain.Entity
{
    public class User:BaseEntity
    {
        public string? Name { get; set; }
        public UserRole Role{ get; set; }
        public Address? UserAddress { get; set; }
        public Email? email { get; set; }

    }
}
