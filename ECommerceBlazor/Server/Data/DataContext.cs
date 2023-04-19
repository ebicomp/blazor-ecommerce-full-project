using System;
using ECommerceBlazor.Shared;
using Microsoft.EntityFrameworkCore;

namespace ECommerceBlazor.Server.Data
{
	public class DataContext:DbContext
	{
		public DataContext(DbContextOptions<DataContext> options):base(options)
		{

		}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "First product",
                Description = "First product First product First product First product First product First product First product ",
                Price = 99.9m,
                ImageUrl = "https://www.notion.so/cdn-cgi/image/format=auto,width=3840,quality=100/https://images.ctfassets.net/spoqsaf9291f/4LkRwsdriDUzmpgR2QVCf7/95ebe8f6296bd68f14f0ae0291cb51c0/Productwiki.png"
            },
        new Product
        {
            Id = 2,
            Name = "Second Product",
            Description = "Second Product Second Product Second Product Second Product Second Product Second Product Second Product Second Product Second Product Second Product ",
            Price = 99.9m,
            ImageUrl = "https://www.notion.so/cdn-cgi/image/format=auto,width=3840,quality=100/https://images.ctfassets.net/spoqsaf9291f/4LkRwsdriDUzmpgR2QVCf7/95ebe8f6296bd68f14f0ae0291cb51c0/Productwiki.png"
        },
                new Product
                {
                    Id = 3,
                    Name = "Third Product ",
                    Description = "Third Product Third Product Third Product Third Product Third Product Third Product Third Product Third Product ",
                    Price = 99.9m,
                    ImageUrl = "https://www.notion.so/cdn-cgi/image/format=auto,width=3840,quality=100/https://images.ctfassets.net/spoqsaf9291f/4LkRwsdriDUzmpgR2QVCf7/95ebe8f6296bd68f14f0ae0291cb51c0/Productwiki.png"
                }
);
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Product> Products { get; set; }
	}
}

