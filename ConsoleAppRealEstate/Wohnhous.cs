﻿using System;
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
        List<Wohnung> _WohnungList { get; set; }  //List<Wohnung> wohnungList, 

        //7bool? _hasBelcony { get; set; }   
        public Wohnhous(int bauJahr): base( bauJahr ) 
        {

            
            
           // this._WohnungList = wohnungList;
            //this._hasBelcony = hasBelcony;
           

        }

    }
}