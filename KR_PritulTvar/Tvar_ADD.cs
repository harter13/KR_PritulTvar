using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KR_PritulTvar
{

    public class Tvar_ADD
    {

        public int Id { get; set; }

        public virtual Type Type { get; set; }

        public virtual Breed Breed { get; set; }

        public string Nick { get; set; }

        public double Age { get; set; }

        public double Kg { get; set; }
    
        public virtual Color Color { get; set; }
    
        public DateTime DateTime { get;set; }
       
        public bool Vaccination { get; set; }
      
        public bool Castration { get; set; }
   
        public string Information { get; set; }
      
        public virtual RegUser RegisterUser { get; set; }

    }

}