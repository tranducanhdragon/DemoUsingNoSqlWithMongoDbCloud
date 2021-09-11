using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Entity;

namespace Web.Core.Service
{
    public interface IBookService
    {
        IEnumerable<Books> GetBooks();
        Books AddBook(Books book);
        Logs AddLog(Logs log);
    }
}
