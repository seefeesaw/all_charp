using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Data;


namespace Todo.Data
{


    public static class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TodoContext(
                serviceProvider.GetRequiredService<DbContextOptions<TodoContext>>()))
            {
                // Look for any
                if (context.Todos.Any())
                {
                    return;   // Data was already seeded
                }

                context.Todos.AddRange(
                    new Todo
                    {
                        Id = 1,
                        Name = "Buy Milk"
                    },
                    new Todo
                    {
                        Id = 2,
                        Name = "Feed Dog!"
                    });

                context.SaveChanges();
            }
        }
    }

}
