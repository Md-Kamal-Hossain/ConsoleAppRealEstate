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
        //public RealEstate(int bauJahr, int propertySize, int livingSpace, int basementArea, string heatingSystem, string streetName, string houseNo, string city, string zipCode)
        //{
        //    this.bauJahr = bauJahr;
        //    //this.propertySize = propertySize;
        //    //this.livingSpace = livingSpace;
        //    //this.basementArea = basementArea;
        //    //this.heatingSystem = heatingSystem;
        //    //this.streetName = streetName;
        //    //this.houseNo = houseNo;
        //    //this.city = city;
        //    //this.zipCode = zipCode;
        //}

        public RealEstate(int bauJahr)
        {
            this.bauJahr = bauJahr;
        }
    }
}
