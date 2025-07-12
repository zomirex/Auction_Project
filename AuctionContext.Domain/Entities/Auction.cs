using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AuctionContext.Domain.Common.BaseClasses;
using AuctionContext.Domain.Common.Enums;
using AuctionContext.Domain.Entity.Args;
using AuctionContext.Domain.Services;
using AuctionContext.Domain.Valuobj.Auction;
using AuctionContext.Domain.Valuobj.Bid;
using AuctionContext.Domain.Valuobj.ETC;
namespace AuctionContext.Domain.Entity
{
    public class Auction : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        protected DateTime StartTime { get; set; }
        protected DateTime EndTime { get; set; }
        protected AuctionState State { get; set; }
        public Bid WinningBid { get; set; }
        public List<Bid> Bids { get; private set; }
        public AuctionProfile? AuctionSummerry { get; set; }
        public BidIncreament? BidIncreament { get; set; }
        private Auction()
        {

        }
        private Auction(RegisterAuction args)
        {
            Title = args.Title;
            Description = args.Description;
            StartTime = args.StartTime;
            EndTime = args.EndTime;
            State = AuctionState.Started;


        }
        public static async Task<Auction> CreateAsync(RegisterAuction args, CancellationToken token)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args), "Auction arguments cannot be null.");
            }
            if (args.StartTime >= args.EndTime)
            {
                throw new ArgumentException("Start time must be before end time.");
            }
            token.ThrowIfCancellationRequested();
            return new Auction(args);
        }
        public async Task Modify(ModifyAuction arg, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();
            if (State == AuctionState.Started)
            {
                Title = arg.Title;
                Description = arg.Description;
                StartTime = arg.StartTime;
                EndTime = arg.EndTime;
            }


        }
        public void Remove()
        {
            ///////Logic
            IsDelete = true;
            DeleteTime = DateTime.UtcNow;
        }
        public Bid GetWinningBid()
        {
            return WinningBid;
        }
        //public async Task PlaceBid(User user, Money Amount, CancellationToken token)
        //{
        //    if (Amount.Amount%BidIncreament.Increament.Amount != 0)
        //    {
        //        throw new ArgumentException("Bid amount must be a multiple of the bid increment.");
        //    }
        //    if (IsDelete == true)
        //    {
        //        throw new InvalidOperationException("Auction has been deleted and cannot accept bids.");
        //    }
        //    if (DateTime.Now>=EndTime ||DateTime.Now<=StartTime)
        //        return ;
        //    token.ThrowIfCancellationRequested();
        //    if (State != AuctionState.InProgress)
        //    {
        //        throw new InvalidOperationException("Auction is not in a state to accept bids.");
        //    }
        //    if (WinningBid.Price == Amount)
        //    {
        //        if (WinningBid.CreatedAt > DateTime.Now)
        //        {
        //            WinningBid = await Bid.CreateAsync(new RigesterBid
        //            {
        //                BidderId = user.Id,
        //                AuctionId = Id,
        //                Price = Amount
        //            });
        //            Bids.Add(WinningBid);
        //        }
        //    }
        //    else if (WinningBid.Price < Amount)
        //    {
        //        WinningBid = await Bid.CreateAsync( new RigesterBid {
        //            BidderId=user.Id,
        //            AuctionId=Id,
        //            Price= Amount


        //        });
        //        Bids.Add(WinningBid);
        //    }

        //}
        public void PlaceBid(Bid newBid)
        {
            if (IsDelete)
                throw new InvalidOperationException("Auction has been deleted.");

            if (DateTime.Now >= EndTime || DateTime.Now <= StartTime)
                return;

            if (State != AuctionState.InProgress)
                throw new InvalidOperationException("Auction not in progress.");

            if (newBid.Price.Amount % BidIncreament.Increament.Amount != 0)
                throw new ArgumentException("Invalid increment.");

            if (WinningBid == null || newBid.Price > WinningBid.Price ||
                (newBid.Price == WinningBid.Price && newBid.CreatedAt < WinningBid.CreatedAt))
            {
                WinningBid = newBid;
                Bids.Add(newBid);
            }
        }
    }
}
