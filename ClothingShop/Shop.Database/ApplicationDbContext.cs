using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Shop.Domain.Models;
using Microsoft.EntityFrameworkCore;



namespace Shop.Database

{
    public class ApplicationDbContext : IdentityDbContext 
    {
        //adds the product to the database
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        //adds the product data to Products property in the database
        public DbSet<Product> Products { get; set; }
    }
}
