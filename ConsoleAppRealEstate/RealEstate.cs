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
       public  int bauJahr { get; set; }   
       public  double propertySize { get; set; }  
       public  double? livingSpace { get; set; }   
       public double? basementArea { get; set; }  
       public HeatingSystems? HeatingSystems { get; set; } 
       public string streetName { get; set; } 
       public string houseNo { get; set; }    
       public string city { get; set; }
       public string zipCode { get; set; }
        

        public RealEstate(int bauJahr)
        {
            this.bauJahr = bauJahr;
        }
    }
}
