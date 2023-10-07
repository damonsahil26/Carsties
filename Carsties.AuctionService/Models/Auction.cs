using Carsties.AuctionService.Enums;

namespace Carsties.AuctionService.Models
{
    public class Auction
    {
        public Guid Id { get; set; }    
        public int ReservePrice { get; set; }
        public string Seller { get; set; } = string.Empty;
        public string? Winner { get; set; }
        public int? SoldAmount { get; set; }
        public int? CurrentHighBid { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime AuctionEndedAt { get; set; }
        public Status Status { get; set; } = Status.Live;
        public Item? Item { get; set; }
    }
}
