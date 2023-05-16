using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRealEstate
{
    public class Wohnung: Wohnhous
    {
        
        double _livingSpace { get; set; }
      
        int _noOfRooms { get; set; }
        bool? _hasBelcony { get; set; }
        public Wohnung(int bauJahr, double livingSpace, int noOfRooms, bool hasBelcony):base(bauJahr)
        {
            this._noOfRooms = noOfRooms;
            this._livingSpace = livingSpace;    
            this._hasBelcony = hasBelcony;  


        }
    }
}
