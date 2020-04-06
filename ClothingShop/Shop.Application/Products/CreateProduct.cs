using System;
using System.Collections.Generic;
using System.Text;
using Shop.Database;
using Shop.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Shop.Application.Products
{
    public class CreateProduct
    {
        public ApplicationDbContext _context;

        //constructor imports data from DbContext
        public CreateProduct(ApplicationDbContext context)
        {
            _context = context;
        }


        public void Do(int id, string Name, string Description)
        {
            _context.Products.Add(new Product
            {
                Id = id,
                Name = Name,
                Description = Description
            });

        }
    }
}
