using System;
using System.Runtime.Serialization;

namespace KR_PritulTvar
{
    [DataContract]
    public class RegUser_DTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SurName { get; set; }
        [DataMember]
        public string Tel { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int TvarID { get; set; }
    }
    
}