using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Context;


namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await _context.BlogPosts
                .Where(p => p.IsPublished)
                .OrderByDescending(p => p.CreatedDate)
                .ToListAsync();

            return View(posts);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var post = await _context.BlogPosts
                .FirstOrDefaultAsync(p => p.Id == id && p.IsPublished);

            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }
    }
}