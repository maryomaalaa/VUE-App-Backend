using Microsoft.AspNetCore.Mvc;
using BackendProject.Data;
using BackendProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace BackendProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CommentsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Comments?postId=5
        [HttpGet]
        public IActionResult GetComments(int postId)
        {
            var comments = _context.Comments.Where(c => c.PostId == postId).ToList();
            return Ok(comments); // Even if it's empty, this should return []
        }

        // POST: api/Comments
        [HttpPost]
        public IActionResult AddComment([FromBody] Comment comment)
        {
            if (comment == null)
            {
                return BadRequest("Comment cannot be null");
            }

            _context.Comments.Add(comment);
            _context.SaveChanges();

            return Ok(comment);
        }

    }
}
