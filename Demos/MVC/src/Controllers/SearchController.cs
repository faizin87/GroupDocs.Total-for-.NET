﻿using System.Web.Mvc;

namespace GroupDocs.Total.MVC.Controllers
{
    /// <summary>
    /// Search Web page controller
    /// </summary>
    public class SearchController : Controller
    {       
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}