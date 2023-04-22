using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connor.Bohlin.Models
{ // This class holds the data that will be gathering and will be validated and then converted to be sent to the database.
    public class Pokemon
    {

        public int PokedexId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public string Gender { get; set; }
        public string Nature { get; set; }
        public string Message { get; set; }
    }

}
