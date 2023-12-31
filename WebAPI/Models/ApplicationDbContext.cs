using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WebAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
           {

           }


        public DbSet<Villa> Villas {get; set;}
        
         protected override void OnModelCreating(ModelBuilder modelBuilder){
             base.OnModelCreating(modelBuilder);
             modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    Occupancy=4,
                    Rate = 200, 
                    Sqft = 550
                },
                new Villa
                {
                    Id = 2,
                    Name = "Premium Pool Villa",
                    Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    Occupancy=4,
                    Rate = 300, 
                    Sqft = 550
                },
                new Villa
                {
                    Id = 3,
                    Name = "Luxury Pool Villa",
                    Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    Occupancy=4,
                    Rate = 400, 
                    Sqft = 750
                },
                new Villa
                {
                    Id = 4,
                    Name = "Diamond Villa",
                    Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    Occupancy=4,
                    Rate = 550, 
                    Sqft = 900
                },new Villa
                {
                    Id = 5,
                    Name = "Diamond Pool Villa",
                    Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    Occupancy=5,
                    Rate = 600, 
                    Sqft = 1150
                }


             );

         
         
        }  
    }
}