using KisiselWebSitesi_MVC.Models;
using System.Linq;
using System.Web.Mvc;

namespace KisiselWebSitesi_MVC.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Anasayfas.ToList();
            return View(deger);
        }

        public PartialViewResult ikonlar()
        {
            var deger = c.ikonlars.ToList();
            return PartialView(deger);
        }
    }
}