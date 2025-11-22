using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ZTAM.Api.Models;

namespace ZTAM.Api
{
    public class ZTAMContext : DbContext
    {
        public ZTAMContext(DbContextOptions<ZTAMContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<ApplicationEntity> Applications { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<AccessLog> AccessLogs { get; set; }
    }
}

