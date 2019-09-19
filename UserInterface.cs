using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
  public static class UserInterface
    {
       public static void ContestantCreator(Contestant contestant)
        {
            Console.WriteLine("What is your first name?");
           contestant.firstname = Console.ReadLine().ToLower();

            Console.WriteLine("What is your last name?");
            contestant.lastname = Console.ReadLine().ToLower();

            Console.WriteLine("What is your email?");
            contestant.email = Console.ReadLine().ToLower();
        }

        public static string DatabaseFinder()
        {
            Console.WriteLine("Stack or Queue");
            string response = Console.ReadLine().ToLower();
            return response;
          
        }
        public static void DisplayWinnerInfo(Contestant contestant)
        {
            Console.WriteLine("First Name: " + contestant.firstname);
            Console.WriteLine("Last Name: " + contestant.lastname);
            Console.WriteLine("Email: " + contestant.email);
            Console.ReadLine();
        }
    }
}
