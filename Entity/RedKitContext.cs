using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class RedKitContext:DbContext
    {
        public RedKitContext():base("name=RedKitDB")
        {
          
        }
        public DbSet<signUp> SignUp { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
