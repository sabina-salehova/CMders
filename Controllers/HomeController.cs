using Microsoft.AspNetCore.Mvc;

namespace CMders.Controllers
{
    public class HomeController : Controller
    {
        //public ContentResult Index()
        //{
        //    return Content("CONTENT");
        //}

        //public JsonResult Index()
        //{
        //    return Json("JSON RESULT");
        //}

        //public ViewResult Index()
        //{
        //    ViewResult view = new ViewResult
        //    {
        //        ViewName="index"
        //    };
        //    return view;
        //}

        //public ViewResult About() 
        //{
        //    return new ViewResult { ViewName="About"};
        //}

        // ------------------------   ViewResult, Json Result, ContentResult her biri ActionResult-dan miras aldigi ucun geri donuw tipini Action Result yaziriq. -----

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
