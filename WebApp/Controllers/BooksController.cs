using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Core.Entity;
using Web.Core.Service;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {

        private IBookService _service;
        public BooksController(IBookService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok( _service.GetBooks());
        }
        [HttpPost]
        [Route("AddBook")]
        public IActionResult Add(Books book)
        {
            _service.AddBook(book);
            return Ok(book);
        }
        [HttpPost]
        [Route("AddLog")]
        public IActionResult AddLog(Logs log)
        {
            _service.AddLog(log);
            return Ok(log);
        }
    }
}
