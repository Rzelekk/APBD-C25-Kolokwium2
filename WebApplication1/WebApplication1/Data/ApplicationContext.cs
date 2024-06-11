using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class ApplicationContext : DbContext
{
    protected ApplicationContext()
    {
    }

    public ApplicationContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Items> Items { get; set; }
    public DbSet<Titles> Titles { get; set; }
    public DbSet<Characters> Characters { get; set; }
    public DbSet<CharacterTitles> CharacterTitles { get; set; }
    public DbSet<Backpacks> Backpacks { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Items>().HasData(new List<Items>
        {
            new Items
            {
                Id = 1,
                Name = "Item1",
                Weight = 12
            },
            new Items
            {
                Id = 2,
                Name = "Item2",
                Weight = 32
            }
        });

        modelBuilder.Entity<Titles>().HasData(new List<Titles>
        {
            new Titles()
            {
                Id = 1,
                Name = "Title1",
            },
            new Titles()
            {
                Id = 2,
                Name = "Title2",
            }
        });

        modelBuilder.Entity<Characters>().HasData(new List<Characters>
        {
            new Characters()
            {
                Id = 1,
                FirstName = "Jan",
                LastName = "Kowalski",
                CurrentWei = 90,
                MaxWeight = 100
            },
            
            new Characters()
            {
                Id = 2,
                FirstName = "Wan",
                LastName = "Jarski",
                CurrentWei = 60,
                MaxWeight = 80
            }
        });

        modelBuilder.Entity<Backpacks>().HasData(new List<Backpacks>
        {
            new Backpacks()
            {
                CharacterId = 1,
                ItemId = 2,
                Amount = 32
            },
            new Backpacks()
            {
                CharacterId = 1,
                ItemId = 1,
                Amount = 1
            },
            new Backpacks()
            {
                CharacterId = 2,
                ItemId = 1,
                Amount = 32
            },
            new Backpacks()
            {
                CharacterId = 2,
                ItemId = 2,
                Amount = 2
            }
        });

        modelBuilder.Entity<CharacterTitles>().HasData(new List<CharacterTitles>
        {
            new CharacterTitles
            {
              CharacterId = 1,
              TitleId = 1
            },
            new CharacterTitles
            {
                CharacterId = 2,
                TitleId = 2
            },
        });
    }
}