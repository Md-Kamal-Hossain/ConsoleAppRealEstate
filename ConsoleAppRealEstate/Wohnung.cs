using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRealEstate
{
    public class Wohnung: Wohnhous
    {
        
        public double LivingSpace { get;  }
      
        public int NoOfRooms { get;  }
        public bool? HasBelcony { get;  }
        public Wohnung(int bauJahr, double livingSpace, int noOfRooms, bool hasBelcony):base(bauJahr)
        {
            this.NoOfRooms = noOfRooms;
            this.LivingSpace = livingSpace;    
            this.HasBelcony = hasBelcony;  


        }
    }
}
