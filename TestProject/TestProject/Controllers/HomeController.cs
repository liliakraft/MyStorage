using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProject.Models;

namespace TestProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserDetailsRepository userRepository;

        public HomeController(IUserDetailsRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new UserDetailsViewModel());
        }

        [HttpPost]
        public ActionResult Index(UserDetailsViewModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return View(inputModel);
            }

            var model = new User();
            model.Name = inputModel.Name;
            model.Category = inputModel.Category;

            userRepository.Save(model);

            return View();
        }
    }
}
