using System;
using Microsoft.EntityFrameworkCore;
using BackendProject.Models;  // Ensure this points to where your 'Post' model is located


namespace BackendProject.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }

}
