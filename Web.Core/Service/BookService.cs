using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.DbConfig;
using Web.Core.Entity;

namespace Web.Core.Service
{
    public class BookService : IBookService
    {
        private IDbClient _dbClient;
        public BookService(IDbClient dbClient)
        {
            _dbClient = dbClient;
        }
        public IEnumerable<Books> GetBooks()
        {
            return _dbClient.GetBooksCollection().Find(book => true).ToList();
            
        }
        public Books AddBook(Books book)
        {
            _dbClient.AddBook(book);
            return book;
        }
        public Logs AddLog(Logs log)
        {
            _dbClient.AddLog(log);
            return log;
        }
    }
}
