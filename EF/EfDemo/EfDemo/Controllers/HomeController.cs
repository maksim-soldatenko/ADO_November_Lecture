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
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _authorsRepository = _unitOfWork.Repository<Author>();
            _booksRepository = _unitOfWork.Repository<Book>();
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
            var included = _booksRepository.Include(books, include.ToArray());

            var model = new BookPublisherModel() {BookModels = new List<BookModel>()};
            foreach (var book in included)
            {
                var bookModel = new BookModel() {Book = book, Publishers = book.Publishers};
                model.BookModels.Add(bookModel);
            }

            return View(model);
        }

        public void UpdateBook(int bookId, string annotation, byte[] rowVersion)
        {
            var book = _booksRepository.GetById(bookId);

            if (book == null)
            {
                throw new Exception("Book not found");
            }

            book.Annotation = annotation;
            book.RowVersion = rowVersion;
            _booksRepository.Update(book);
            _unitOfWork.Save();
        }
    }
}