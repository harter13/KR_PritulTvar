﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace KR_PritulTvar
{
    [DataContract]
    public class Type
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public virtual ICollection<Tvar_ADD> Tvar_Registrs { get; set; }
        [DataMember]
        public string NameType { get; set; }
    }
}