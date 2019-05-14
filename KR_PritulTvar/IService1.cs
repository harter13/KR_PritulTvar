using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KR_PritulTvar
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool SingIn(SingInUser User);
        [OperationContract]
        bool SetUser(RegUser user);
        [OperationContract]
        void SetTvarina(Tvar_ADD tvar, SingInUser User);
        [OperationContract]
        IEnumerable<Tvar_ADD_DTO> GetTvar();
        [OperationContract]
        IEnumerable<RegUser_DTO> GetUser();
        [OperationContract]
        void RemoveTvar(int Id);
    }

}
