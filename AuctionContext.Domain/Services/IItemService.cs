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
    // Check Existance or availibility
    public interface IItemService
    {
        // check item created time to validate it
        public bool CheckDate(DateTime date);
        // check if it was a mock to return false
        public bool IsAvailable(DbContext context);
    }
}
