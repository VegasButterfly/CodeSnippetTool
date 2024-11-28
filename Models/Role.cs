﻿namespace CodeSnippetTool.Models
{
    public class Role
    {
        public int Id { get; set; }
        public required string RoleName { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();

    }
}
