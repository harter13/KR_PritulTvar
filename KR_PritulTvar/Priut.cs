namespace KR_PritulTvar
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Priut : DbContext
    {

        public Priut(): base("name=Priut")
        {

        }
        public virtual DbSet<RegUser> RegUsers { get; set; }
        public virtual DbSet<Tvar_ADD> Tvar_Add { get; set; }
        public virtual DbSet<Breed> Breeds { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Type> Types { get; set; }
    }


}