using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Entity;

namespace Web.Core.DbConfig
{
    public class DbClient : IDbClient
    {
        private readonly IOptions<BookstoreDbConfig> _bookstoreDbConfig;
        private readonly IMongoCollection<Books> _books;
        private readonly IMongoCollection<Logs> _logs;
        public DbClient(IOptions<BookstoreDbConfig> bookstoreDbConfig)
        {
            _bookstoreDbConfig = bookstoreDbConfig;
            var client = new MongoClient(bookstoreDbConfig.Value.Connection_String);
            var database = client.GetDatabase(bookstoreDbConfig.Value.Database_Name);
            _books = database.GetCollection<Books>(bookstoreDbConfig.Value.Books_Collection_Name);
            _logs = database.GetCollection<Logs>(bookstoreDbConfig.Value.Books_Collection_Name);
        }
        public IMongoCollection<Books> GetBooksCollection()
        {
            return _books;
        }
        public Books AddBook(Books book)
        {
            _books.InsertOne(book);
            return book;
        }

        public Logs AddLog(Logs log)
        {
            _logs.InsertOne(log);
            return log;
        }
    }
}
