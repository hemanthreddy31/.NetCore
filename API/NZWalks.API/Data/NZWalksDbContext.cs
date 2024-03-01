using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed the data for difficulties
            //easy medium hard
            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id=Guid.Parse("e82b4d39-2e1e-472b-be59-25e19c099cb0"),
                    Name="Easy"
                },
                new Difficulty()
                {
                    Id=Guid.Parse("99006a6e-561a-4a87-9050-1c8992b89de0"),
                    Name="Medium"
                },
                  new Difficulty()
                {
                    Id=Guid.Parse("8bc052db-714a-4c2b-b26c-1106a8b98597"),
                    Name="Hard"
                }
            };
            modelBuilder.Entity<Difficulty>().HasData(difficulties);


            //seed the data for regions
            var regions = new List<Region>
            {
                new Region
                {
                    Id=Guid.Parse("c2fa540e-127b-48d3-bd17-9f45cbcfc4fc"),
                    Name="Hyderabad",
                    Code="Hyd",
                    RegionImageUrl="txt.jpg"
                },
                  new Region
                {
                    Id=Guid.Parse("24d71b13-414c-4c1c-b43b-6600ae26b793"),
                    Name="Karimnagar",
                    Code="Knr",
                    RegionImageUrl="txt.jpg"
                },
                    new Region
                {
                    Id=Guid.Parse("9147610d-af6d-416e-8461-0837b6069e27"),
                    Name="Warangal",
                    Code="Wrg",
                    RegionImageUrl="txt.jpg"
                },
                      new Region
                {
                    Id=Guid.Parse("002a59c7-2dbc-4b67-94f4-234f0fce958d"),
                    Name="Ranga reddy",
                    Code="RR",
                    RegionImageUrl="txt.jpg"
                }
            };
            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
