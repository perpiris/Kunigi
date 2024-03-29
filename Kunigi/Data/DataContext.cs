﻿using Kunigi.Entities;
using Microsoft.EntityFrameworkCore;
using File = Kunigi.Entities.File;

namespace Kunigi.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Team> Teams { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Puzzle> Puzzles { get; set; }
    public DbSet<File> Files { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>()
            .HasOne(g => g.Host)
            .WithMany(t => t.HostedGames)
            .HasForeignKey(g => g.HostId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Game>()
            .HasOne(g => g.Winner)
            .WithMany(t => t.WonGames)
            .HasForeignKey(g => g.WinnerId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}