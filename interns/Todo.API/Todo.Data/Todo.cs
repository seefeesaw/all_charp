using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Data
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IsCompleted { get; set; }
        public DateTime Created { get; set; }
    }
}
