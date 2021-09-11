using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Entity;

namespace Web.Core.DbConfig
{
    public interface IDbClient
    {
        IMongoCollection<Books> GetBooksCollection();
        Books AddBook(Books book);
        Logs AddLog(Logs log);
    }
}
