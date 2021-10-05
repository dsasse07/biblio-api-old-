using System;

namespace BiblioApi.Models
{
    public class TodoList
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
