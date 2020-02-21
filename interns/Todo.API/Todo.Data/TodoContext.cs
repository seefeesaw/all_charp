using Microsoft.EntityFrameworkCore;
using System;

namespace Todo.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)        {        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().Property(t => t.Name).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Todo> Todos { get; set; }
    }
}
