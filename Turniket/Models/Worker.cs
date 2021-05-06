using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turniket.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Identity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay  { get; set; }
    }
}
