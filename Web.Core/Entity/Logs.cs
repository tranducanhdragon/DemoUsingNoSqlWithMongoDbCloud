using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Core.Entity
{
    public class Logs
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string User { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
