using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_BackEnd.Models
{
    public class mudPump
    {
        //свойство id выступает в качестве уникального идентификатора ключа в РБД
        public int id { get; set; }

        public string nameObject { get; set; }

        public int numberOfCylinders { get; set; }

        public double power { get; set; }

        public double maxPressure { get; set; }

        public string nameCompany { get; set; }

        public double price { get; set; }

        public bool isHere { get; set; }

        public IEnumerable<mudPump> mudP {get;set;}


     


    }
}
