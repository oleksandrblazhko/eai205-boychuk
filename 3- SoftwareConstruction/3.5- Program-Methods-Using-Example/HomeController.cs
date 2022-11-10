
using Microsoft.AspNetCore.Mvc;
using Sleep_Safety_Reading.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Sleep_Safety_Reading.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public SleepSafetyReadingContext db = new SleepSafetyReadingContext();
        private readonly UserManager<User> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<User> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public Task<IActionResult> addSleep(Sleep sleep)
        {
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int userId = Convert.ToInt32(userID);
            sleep.userId = userId;
            sleep.user = db.Users.Find(userId);
            db.Sleeps.Add(sleep);

            db.SaveChanges();

            return View();
        }

        public async Task<IActionResult> Sleeps()
        {
            return View();
        }

    }
}
