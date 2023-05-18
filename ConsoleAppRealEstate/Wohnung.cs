using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRealEstate
{
    public class Wohnung: Wohnhous
    {
        
        public double LivingSpace { get; } // only "get" As it needs to be read only

        public int NoOfRooms { get; } // only "get" As it needs to be read only
        public bool? HasBelcony { get; } //only "get" As it needs to be read only
        public Wohnung(int bauJahr, double livingSpace, int noOfRooms, bool hasBelcony):base(bauJahr)
        {
            this.NoOfRooms = noOfRooms;
            this.LivingSpace = livingSpace;    
            this.HasBelcony = hasBelcony;  


        }
    }
}
