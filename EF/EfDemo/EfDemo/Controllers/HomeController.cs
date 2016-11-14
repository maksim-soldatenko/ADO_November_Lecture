using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dal.Domain;
using Dal.Repository;
using EfDemo.Models;

namespace EfDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Author> _authorsRepository;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _authorsRepository = unitOfWork.Repository<Author>();
        }

        public ActionResult Index()
        {
            var authors = _authorsRepository.GetAll().ToList();
            var model = new AuthorsModel() {Authors = authors};
            return View(model);
        }
    }
}