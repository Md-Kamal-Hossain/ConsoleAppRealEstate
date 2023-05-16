using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppRealEstate;

namespace ConsoleAppRealEstate
{
    public abstract class RealEstate
    {
        int bauJahr { get; set; }   
        double propertySize { get; set; }  
        double? livingSpace { get; set; }   
        double? basementArea { get; set; }  
        HeatingSystems? HeatingSystems { get; set; } 
        string streetName { get; set; } 
        string houseNo { get; set; }    
        string city { get; set; }
        string zipCode { get; set; }
        

        public RealEstate(int bauJahr)
        {
            this.bauJahr = bauJahr;
        }
    }
}
