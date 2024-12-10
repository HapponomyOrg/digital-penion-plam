﻿using System;

namespace Version1.Market
{
    public struct Bid
    {
        public Guid BidId { get; private set; }
        public int Bidder { get; private set; }
        public int OfferedPrice { get; private set; }
        public BidStatus BidStatus { get; private set; }
        public DateTime TimeStamp { get; private set; }

        public Bid(Guid bidId, int bidder, int offeredPrice, DateTime timeStamp)
        {
            BidId = bidId;
            Bidder = bidder;
            OfferedPrice = offeredPrice;
            BidStatus = BidStatus.Active;
            TimeStamp = timeStamp;
        }

        public void AcceptBidding()
        {
            BidStatus = BidStatus.Accepted;
        }
        
        public void RejectBidding()
        {
            BidStatus = BidStatus.Rejected;
        }

        public override string ToString()
        {
            return $"BidId: {BidId}, Bidder: {Bidder}, OfferedPrice: {OfferedPrice}, BidStatus: {BidStatus}, Timestamp: {TimeStamp}";
        }
    }
}