using AuctionContext.Domain.Common.Interfaces;
using AuctionContext.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionContext.Domain.Services
{
    //#todo 
    //methods
    //  check time to be true
    //  check to be one 
    //  check each person role for placing the bid
    //  
    public interface IAuctionService:IService
    {
        public bool CheckTime(DateTime time);
        public bool IsDuplicate(DbContext context );
        public bool CheckRole(User user);
    }
}
