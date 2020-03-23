using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class ActivationCode:BaseEntity
    {
        public string Code { get; set; }
        public bool IsActive { get; set; }
    }
}
