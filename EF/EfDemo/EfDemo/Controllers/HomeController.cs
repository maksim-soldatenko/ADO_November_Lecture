using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        private readonly IRepository<Book> _booksRepository;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _authorsRepository = unitOfWork.Repository<Author>();
            _booksRepository = unitOfWork.Repository<Book>();
        }

        public ActionResult Index()
        {
            var authors = _authorsRepository.GetAll().ToList();
            var model = new AuthorsModel() {Authors = authors};
            return View(model);
        }

        public ActionResult BooksByAuthor(int id)
        {
            var include = new List<Expression<Func<Book,object>>>();
            include.Add(b=>b.Publishers);

            var books = _booksRepository.Find(b => b.Author.Id == id);
            _booksRepository.Include(books, include.ToArray());

            var model = new BookPublisherModel() {BookModels = new List<BookModel>()};
            foreach (var book in books)
            {
                var bookModel = new BookModel() {Book = book, Publishers = book.Publishers};
                model.BookModels.Add(bookModel);
            }

            return View(model);
        }
    }
}