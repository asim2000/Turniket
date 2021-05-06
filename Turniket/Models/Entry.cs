using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turniket.Models
{
    public class Entry
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public DateTime EntryTime { get; set; }
    }
}
