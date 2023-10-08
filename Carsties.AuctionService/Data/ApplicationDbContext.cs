using Carsties.AuctionService.Models;
using Microsoft.EntityFrameworkCore;

namespace Carsties.AuctionService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
