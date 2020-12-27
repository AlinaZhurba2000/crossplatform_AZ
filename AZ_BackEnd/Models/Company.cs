using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_BackEnd.Models
{
        public class Company
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Country { get; set; }

            public ICollection<mudPump> pumps { get; set; }
        public int getCountOfMudPumps()
        {
            return pumps.Count;
        }
    }
}

