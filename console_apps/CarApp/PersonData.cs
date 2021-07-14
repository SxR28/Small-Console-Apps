using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    public class PersonData : License
    {
        public string personName { get; set;  }
        public int personAge { get; set; }
        public double personHeight { get; set; }
        
        public string personContinent { get; set; }
    }
}
