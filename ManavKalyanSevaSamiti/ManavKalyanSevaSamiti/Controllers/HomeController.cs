using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManavKalyanSevaSamiti.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PhotoGallery()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult RotatePhotoGallery()
        {
            return View();
        }        
        public ActionResult TextRotate()
        {
            return View();
        }
        public ActionResult PhotoRotate()
        {
            return View();
        }
        public ActionResult InfiniteImageLoop()
        {
            return View();
        }
        public ActionResult ImageGalleryZoom()
        {
            return View();
        }
        public ActionResult CardRotate()
        {
            return View();
        }
        public ActionResult PresidentProfile()
        {
            return View();
        }
        public ActionResult PhotoCovers()
        {
            return View();
        }
        public ActionResult ImageReflection()
        {
            return View();
        }  
        public ActionResult Perspective3DMouseOver()
        {
            return View();
        }
        public ActionResult GlassEffect()
        {
            return View();
        }
        public ActionResult ImageHover()
        {
            return View();
        }
        public ActionResult DashBoard()
        {
            return View();
        }
        public ActionResult Accordian()
        {
            return View();
        }
    }
}