using FlyCart.Entities;
using FlyCart.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyCart.Web.Controllers
{
    public class CatagoryController : Controller
    {
        CatagoryServices catagoryServices = new CatagoryServices();
        [HttpGet]
        public ActionResult Index()
        {
            var catagoriesList = catagoryServices.GetCatagories();
            return View(catagoriesList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Catagory catagory)
        {
            catagoryServices.CreateCatagory(catagory);
            return RedirectToAction("Index","Catagory");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var sldCatagory = catagoryServices.GetCatagory(Id);
            return View(sldCatagory);
        }

        [HttpPost]
        public ActionResult Edit(Catagory catagory)
        {
            catagoryServices.EditCatagory(catagory);
            return RedirectToAction("Index", "Catagory");
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var sldCatagory = catagoryServices.GetCatagory(Id);
            return View(sldCatagory);
        }

        [HttpPost]
        public ActionResult Delete(Catagory catagory)
        {
            var dltCatagory = catagoryServices.GetCatagory(catagory.ID);
            catagoryServices.DeleteCatagory(dltCatagory);
            return RedirectToAction("Index", "Catagory");
        }
    }
}