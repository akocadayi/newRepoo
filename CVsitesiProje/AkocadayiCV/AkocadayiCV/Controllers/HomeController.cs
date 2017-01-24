using System.Text;
using System.Web.Mvc;


namespace AkocadayiCV.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult hakkimda()
        {
            return View();
        }
        public ActionResult iletisim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult index()
        {
                    return View();
        }
    }
}
