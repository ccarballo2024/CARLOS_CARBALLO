using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_tecnica.Models
{
    public class TaskContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<PendingTask> Tasks { get; set; }

        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Esto asegura que ASP.NET Identity puede configurar sus tablas
            modelBuilder.Entity<PendingTask>().ToTable("Tasks");
        }
    }
}
