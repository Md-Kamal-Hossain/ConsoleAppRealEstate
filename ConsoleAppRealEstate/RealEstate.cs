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
       public  int BauJahr { get; }  //only "get" As it needs to be read only 
       public  double PropertySize { get; set; }  
       public  double? LivingSpace { get; set; }   
       public double? BasementArea { get; set; }  
       public HeatingSystems? HeatingSystems { get; set; } 
       public string StreetName { get; set; } 
       public string HouseNo { get; set; }    
       public string City { get; set; }
       public string ZipCode { get; set; }
        

        public RealEstate(int bauJahr)
        {
            this.bauJahr = bauJahr;
        }
    }
}
