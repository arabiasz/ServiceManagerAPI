using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceManager.Models;
using ServiceManagerAPI.Models;

namespace ServiceManager.Data
{
    public class ServiceManagerContext : DbContext
    {
        public ServiceManagerContext (DbContextOptions<ServiceManagerContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Producer> Producer { get; set; }
        public DbSet<DevicesFolder> DevicesFolder { get; set; }
        public DbSet<Device> Devices { get; set; }
    }
}
