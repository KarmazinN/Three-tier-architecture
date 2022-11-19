using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entityes;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    internal class EFDBContext : DbContext
    {
        public DbSet<Directory> Directories { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Page> Page { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options) { }
    }
}
