﻿using System;

namespace Blog.Database.Domain
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; } = DateTime.Now;
    }
}
