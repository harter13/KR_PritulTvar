using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KR_PritulTvar
{
    public class Service1 : IService1
    {
        //private readonly Priut Priut = new Priut();
        //private bool disposed = false;

        public bool SingIn(SingInUser User)
        {
            using (Priut db = new Priut())
            {
                bool e = db.RegUsers.ToList().Any(w => w.Email == User.EmailSingIn && w.Password == User.PasswordSingIn);
                return e;  
            }
        }
        public bool SetUser(RegUser user)
        {
            using (Priut db = new Priut())
            {
                bool emailRepeat = db.RegUsers.ToList().Any(w => w.Email == user.Email);

                if (emailRepeat == true)
                {
                    return emailRepeat;
                }
                else
                {
                    db.RegUsers.Add(user);
                    db.SaveChanges();
                }
                return emailRepeat;
            }
        }

        public void SetTvarina(Tvar_ADD tvar, SingInUser User)
        {
            using (Priut db = new Priut())
            {
                //var tvType = db.Types.ToList().SingleOrDefault(c => c.NameType == tvarDTO.Type) ?? new Type { NameType = tvarDTO.Type };
                //var tvBreed = db.Breeds.ToList().SingleOrDefault(c => c.NameBreed == tvarDTO.Breed) ?? new Breed { NameBreed = tvarDTO.Breed };
                //var tvColor = db.Colors.ToList().SingleOrDefault(c => c.NameColor == tvarDTO.Color) ?? new Color { NameColor = tvarDTO.Color };
                ////var userDb = db.RegUsers.ToList().Single(w => w.Email == User.EmailSingIn);
                //tvarDTO.Type = tvType.NameType;
                //tvarDTO.Breed = tvBreed.NameBreed;
                //tvarDTO.Color = tvColor.NameColor;

                var tvUsers = db.RegUsers.FirstOrDefault(w => w.Email == User.EmailSingIn);
                var tvType = db.Types.FirstOrDefault(w => w.NameType == tvar.Type.NameType);
                var tvBreed = db.Breeds.FirstOrDefault(w => w.NameBreed == tvar.Breed.NameBreed);
                var tvColor = db.Colors.FirstOrDefault(w => w.NameColor == tvar.Color.NameColor);

                if (tvType != null)
                {
                    tvar.Type = tvType;
                }
                else if (tvBreed != null)
                {
                    tvar.Breed = tvBreed;
                }
                else if (tvColor != null)
                {
                    tvar.Color = tvColor;
                }
                tvar.RegisterUser = tvUsers;
                db.Tvar_Add.Add(tvar);
                db.SaveChanges();
            }
        }

        public IEnumerable<Tvar_ADD_DTO>GetTvar()
        {
            using (Priut db = new Priut())
            {
                db.Configuration.ProxyCreationEnabled = false;

                var result = db.Tvar_Add
                .Include(t => t.Type)
                .Include( c => c.Color)
                .Include( b => b.Breed)
                .Select( tv => new Tvar_ADD_DTO
                {
                     Id = tv.Id,
                     Type = tv.Type.NameType,
                     Breed = tv.Breed.NameBreed,
                     Nick = tv.Nick,
                     Age = tv.Age,
                     Kg = tv.Kg,
                     Color = tv.Color.NameColor,
                     DateTime = tv.DateTime,
                     Vaccination = tv.Vaccination,
                     Castration = tv.Castration,
                     Information=tv.Information,
                     UserId = tv.RegisterUser.Id 
                }).ToList();

                return result;
            }
        }

        public IEnumerable<RegUser_DTO> GetUser()
        {
            using (Priut db = new Priut())
            {
                var getUser = db.RegUsers.Select(w => new RegUser_DTO
                {
                    Id = w.Id,
                    Name = w.Name,
                    SurName = w.SurName,
                    Email = w.Email,
                    Tel = w.Tel,
                    Password = w.Password
                }).ToList();

                return getUser;
            }
        }

        public void RemoveTvar(int Id)
        {
            int idDel = Id;
            using (Priut db = new Priut())
            {
                bool auditID = db.Tvar_Add.ToList().Any(w => w.Id == idDel);

                if (auditID == true)
                {
                    var del = db.Tvar_Add.Find(idDel);
                    db.Tvar_Add.Remove(del);
                    db.SaveChanges();
                }
            }
        }


        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!disposed)
        //    {
        //        if (disposing)
        //        {
        //            Priut.Dispose();
        //        }

        //        disposed = true;
        //    }
        //}
        //~Service1()
        //{
        //    Dispose(false);
        //}

    }
}
