using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace KR_PritulTvar
{
    [DataContract]
    public class Tvar_ADD
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public virtual Type Type { get; set; }
        [DataMember]
        public virtual Breed Breed { get; set; }
        [DataMember]
        public string Nick { get; set; }
        [DataMember]
        public double Age { get; set; }
        [DataMember]
        public double Kg { get; set; }
        [DataMember]
        public virtual Color Color { get; set; }
        [DataMember]
        public DateTime DateTime { get;set; }
        [DataMember]
        public bool Vaccination { get; set; }
        [DataMember]
        public bool Castration { get; set; }
        [DataMember]
        public string Information { get; set; }
        [DataMember]
        public virtual RegUser RegisterUser { get; set; }

    }

}