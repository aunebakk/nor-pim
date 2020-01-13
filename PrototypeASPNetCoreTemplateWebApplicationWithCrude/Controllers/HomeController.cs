/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2core.azurewebsites.net/
  Generated Date: 14.02.2018 06:32:45
  Template: sql2x.PrototypeASPNetCoreWebApplication.Content_HomeControllerDOTcs
*/
using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrototypeASPNetCoreTemplateWebApplicationWithCrude.Models;

namespace PrototypeASPNetCoreTemplateWebApplicationWithCrude.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
