﻿using Microsoft.EntityFrameworkCore;

namespace Carsties.AuctionService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
