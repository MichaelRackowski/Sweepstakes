using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
  public static class UserInterface
    {
       public void ContestantCreator(Contestant contestant)
        {
            Console.WriteLine("What is your first name?");
           contestant.firstname = Console.ReadLine().ToLower();

            Console.WriteLine("What is your last name?");
            contestant.lastname = Console.ReadLine().ToLower();

            Console.WriteLine("What is your email?");
            contestant.email = Console.ReadLine().ToLower();

            Console.WriteLine("What is your registration number?");
            contestant.registration = Convert.ToInt32(Console.ReadLine().ToLower());

        }
    }
}
