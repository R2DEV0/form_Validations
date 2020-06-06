using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ProjectName.Models;

namespace ProjectName
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("submit")]
        public ViewResult FormSubmit(Person FromForm)
        {
            if(ModelState.IsValid)
            {
                return View("success");
            }
            else
            {
                return View("Index");
            }
        }
    }
}