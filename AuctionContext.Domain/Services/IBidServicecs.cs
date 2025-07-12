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
    public interface IBidServicecs
    {
        public bool CheckTime(DateTime dateTime);
        public bool IsDuplicate(DbContext context);
    }
}
