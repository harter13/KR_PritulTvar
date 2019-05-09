using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KR_PritulTvar
{
    public class Service1 : IService1
    {
        public void SingIn(RegUser regUser)
        {
            using (Priut db =new Priut())
            {
                db.RegUsers.FirstOrDefault(w => w.Email == regUser.Email);
                db.RegUsers.FirstOrDefault(w => w.Password == regUser.Password);
            }
        }
        public void SetUser(RegUser user)
        {
            Priut dB = new Priut();
            dB.RegUsers.Add(user);
            dB.SaveChanges();
        }

        public void SetTvarina(Tvar_ADD tvar)
        {
            Priut dB = new Priut();
            //dB.Tvar_Add.Add();
        }
    }
}
