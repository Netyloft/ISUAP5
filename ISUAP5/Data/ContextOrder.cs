using System;
using System.ComponentModel.DataAnnotations.Schema;
using ISUAP5.Models;
using Microsoft.EntityFrameworkCore;

namespace ISUAP5.Data
{
    public class ContextOrder : DbContext
    {
        public DbSet<OrderModel> Order { get; set; }

        public ContextOrder(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        
    }
}