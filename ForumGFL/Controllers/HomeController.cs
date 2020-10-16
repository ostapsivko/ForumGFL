using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ForumGFL.Models;
using ForumGFL.Data;
using ForumGFL.Data.RepositoryOfTopics;

namespace ForumGFL.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositoryOfTopics _repository;

        public HomeController(IRepositoryOfTopics repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var topics = _repository.GetAllTopics();
            return View(topics);
        }


        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
