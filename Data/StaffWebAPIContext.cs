using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StaffWebAPI.Models;

namespace StaffWebAPI.Data
{
    public class StaffWebAPIContext : DbContext
    {
        public StaffWebAPIContext (DbContextOptions<StaffWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<StaffWebAPI.Models.StaffName> StaffName { get; set; }
    }
}
