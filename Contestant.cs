using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstname;
        public string lastname;
        public string email;
        public int registration;

         public Contestant(int registration)
        {
           this.registration = registration;
        }
    }
}
