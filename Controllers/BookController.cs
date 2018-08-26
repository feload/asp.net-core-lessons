using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreLessons.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNetCoreLessons.Controllers
{
	public class BookController : Controller
	{
    AppDbContext _context;
		public BookController (AppDbContext context) {
			this._context = context;
		}

		public IActionResult Index()
		{
			var blogs = _context.Blogs.Include(b => b.Posts).ToList();
			return View();
		}
	}
}
