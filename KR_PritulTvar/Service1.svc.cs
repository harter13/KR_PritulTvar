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
        public bool SingIn(SingInUser User)
        {
            using (Priut db = new Priut())
            {
                bool e = db.RegUsers.
                    ToList()
                    .Any(w => w.Email == User.EmailSingIn && w.Password == User.PasswordSingIn);
                return e;  
            }
        }
        public void SetUser(RegUser user)
        {
            Priut dB = new Priut();
            dB.RegUsers.Add(user);
            dB.SaveChanges();
        }

        public void SetTvarina(Tvar_ADD tvar, SingInUser User)
        {
            using (Priut db = new Priut())
            {
                var users = db.RegUsers.FirstOrDefault(w => w.Email == User.EmailSingIn);
                tvar.RegisterUser = users;
                db.Tvar_Add.Add(tvar);
                db.SaveChanges();
            }
        }
    }
}
