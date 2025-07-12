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
    //  check to be one 
    //  add age rule to user
    public interface IUserService
    {
        // check user to be ab adult
        public bool IsAdult(User user );
        // check data base to find a duplicate of recived user
        public bool IsDuplicated( DbContext context );
        // get user data by table in data base
        public User GetUserByDB( DbContext context );
        //get user data by massage broker
        public User GetUserByMSGB( object obj);
    }
}
