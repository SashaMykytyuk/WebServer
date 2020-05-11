using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class Order
    {

        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Cost { get; set; }

        public string State { get; set; }
    }
}
