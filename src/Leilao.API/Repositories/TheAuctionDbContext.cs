﻿using Leilao.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Leilao.API.Repositories;

public class TheAuctionDbContext : DbContext
{
    public TheAuctionDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
}
