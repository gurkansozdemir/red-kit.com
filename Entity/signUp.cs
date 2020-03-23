using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class SignUp:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ActivationCode { get; set; }
    }
}
