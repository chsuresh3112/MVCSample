using MVCWebAPIAdd.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebAPIAdd.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult mathAddition()
        {
            modelAdd _modelAdd = new modelAdd();
            ViewBag.Result = "";
            return View(_modelAdd);
        }
        [HttpPost]
        public ActionResult mathAddition(modelAdd _modelAdd)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string Result = (int.Parse(_modelAdd.number1) + int.Parse(_modelAdd.number2)).ToString();
                    // ModelState.Clear();
                    // ModelState["result"].Value = Result;
                    ModelState.SetModelValue("result", new ValueProviderResult(Result, "", CultureInfo.InvariantCulture));
                }
                return View();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
                return null;
            }
        }


    }
}