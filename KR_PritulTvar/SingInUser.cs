using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace KR_PritulTvar
{
    [DataContract]
    public class SingInUser
    {
        [DataMember]
        public string EmailSingIn { get; set; }
        [DataMember]
        public string PasswordSingIn { get; set; }
    }
}