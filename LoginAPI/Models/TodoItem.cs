﻿namespace LoginAPI.Models
{
    public partial class TodoItem
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Description2 { get; set; }

        public string? Description3 { get; set; }

        public bool IsComplete { get; set; }
    }
}
