using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRealEstate
{
    public class Wohnhous: RealEstate
    {
        int _noOfApartment { get; set; } 
        double _livingSpace { get; set; }
        
        
        public Wohnhous(int bauJahr): base( bauJahr ) 
        {
           

        }

    }
}
