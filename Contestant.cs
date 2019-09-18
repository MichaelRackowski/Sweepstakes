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

         public Contestant(string firstname, string lastname,string email,int registration)
        {
            Contestant contestant = new Contestant(firstname,lastname,email,registration);
           this.firstname = firstname;
           this.lastname = lastname;
           this.email = email;
           this.registration = registration;
        }
    }
}
