using FilmTanitim.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmTanitim.ViewComponents.Yorum
{
    public class YorumListeleme : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public YorumListeleme(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int? id)
        {
            //var userMail = User.Identity.Name;
            //var userId = db.Users.Where(x => x.Email == userMail).Select(y => y.UserId).FirstOrDefault();
            //var userNotsData = db.Nots.Where(x => x.UserId == userId).ToList();
            //var commentList = _context.Comment.Where(x => x.MovieId == id).ToList();
            var comment = _context.Comment.Include(x => x.Movie).ToList();
            return View(comment);
        }
    }
}
