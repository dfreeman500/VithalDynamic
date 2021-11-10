using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VithalDynamic.Data
{
    public class VithalDynamicContext: DbContext
    {

     public VithalDynamicContext(DbContextOptions<VithalDynamicContext> options)
    : base(options)
        {
        }

        public DbSet<VithalDynamic.Models.OrderModel> OrderModels { get; set; }

        public DbSet<VithalDynamic.Models.OrderDetail> OrderDetails { get; set; }
    }
}
