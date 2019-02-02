using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMVC.Models;
using CoreMVC.Data;
using CoreMVC.Models.ViewModels;
using X.PagedList;

namespace CoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public HomeController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LogViewer(string email,int? pageNumber)
        {
            var contracts = _applicationDbContext.Contracts;
            var logs = _applicationDbContext.LogModels;
            ViewLogVM viewLogVM = new ViewLogVM
            {
                Contracts = contracts.ToList(),
                Logs = logs.ToList()
            };

            
            var page = pageNumber ?? 1;
            var onePageOfLogs = logs.ToPagedList(page, 10);
            ViewBag.OnePageOfLogs = onePageOfLogs;
            return View(viewLogVM);
        }
         
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
