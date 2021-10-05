using System;
using Microsoft.EntityFrameworkCore;

namespace BiblioApi.Models
{
    public class TodoListContext : DbContext
    {
        public TodoListContext(DbContextOptions<TodoListContext> options)
            : base(options)
        {
        }

        public DbSet<TodoList> TodoLists { get; set; }
    }
}
