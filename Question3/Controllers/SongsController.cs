using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Question3.Models;

namespace Question3.Controllers
{
    public class SongsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var songs = await _context.Songs.ToListAsync();
            return View(songs);
        }

        public async Task<IActionResult> Add()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            var song = await _context.Songs.FindAsync(id);
            return View(song);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var song = _context.Songs.Find(id);
            _context.Songs.Remove(song);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Add([Bind("Name, ReleasedDate, Artist")] Song data)
        {
            var song = new Song();
            song.Name = data.Name;
            song.ReleasedDate = data.ReleasedDate;
            song.Artist = data.Artist;

            _context.Add(song);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Edit([Bind("Id,Name,ReleaseDate,Artist")] Song data)
        {
            var song = await _context.Songs.FindAsync(data.Id);
            song.Name = data.Name;
            song.ReleasedDate = data.ReleasedDate;
            song.Artist = data.Artist;

            _context.Songs.Update(song);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
