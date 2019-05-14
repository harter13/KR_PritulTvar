using System;
using System.Runtime.Serialization;

namespace KR_PritulTvar
{
    [DataContract]
    public class Tvar_ADD_DTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public  string Breed { get; set; }
        [DataMember]
        public string Nick { get; set; }
        [DataMember]
        public double Age { get; set; }
        [DataMember]
        public double Kg { get; set; }
        [DataMember]
        public string Color { get; set; }
        [DataMember]
        public DateTime DateTime { get; set; }
        [DataMember]
        public bool Vaccination { get; set; }
        [DataMember]
        public bool Castration { get; set; }
        [DataMember]
        public string Information { get; set; }
        [DataMember]
        public int UserId { get; set; }

    }

}