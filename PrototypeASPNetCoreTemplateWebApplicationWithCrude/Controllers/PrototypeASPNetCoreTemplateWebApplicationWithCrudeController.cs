/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2core.azurewebsites.net/
  Generated Date: 14.02.2018 06:32:55
  Template: sql2x.PrototypeASPNetCoreWebApplicationWithCrude.Content_HomeControllerDOTcs
*/
using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    namespace PrototypeASPNetCoreTemplateWebApplicationWithCrude.Controllers
    {
        public class PrototypeASPNetCoreTemplateWebApplicationWithCrudeController : Controller
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
                return View();
            }
        }
    }
    
