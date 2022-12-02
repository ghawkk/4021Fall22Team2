using Microsoft.AspNetCore.Mvc;
using Team2BucHunt.Services;

namespace Team2BucHunt.Controllers
{
    public class bucHuntController : Controller
    {
        private readonly IBucHuntRepository _bucHuntRepository;
        public bucHuntController(IBucHuntRepository bucHuntRepository)
        {
            _bucHuntRepository = bucHuntRepository;
        }

        public async Task<IActionResult> Index()
        {
            var locations = await _bucHuntRepository.ReadAllAsync();
            return View(locations);
        }
        public async Task<IActionResult> Details(int id)
        {
            var location = await _bucHuntRepository.ReadAsync(id);
            if(location == null)
            {
                return RedirectToAction("Index");
            }
            return View(location);
        }
    }
}
