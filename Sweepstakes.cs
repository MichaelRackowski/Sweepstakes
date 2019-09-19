using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        string name;
        int registrationNumber;
        Dictionary<int, Contestant> RegisteredContestant = new Dictionary<int, Contestant>();
        public Sweepstakes(string name)
        {
            this.name = name;
            registrationNumber = 1;
        }

        public void RegisterContestant(Contestant contestant)
        {

            RegisteredContestant.Add(registrationNumber,contestant);
            registrationNumber++;
        }

        public Contestant PickWinner()
        {
            Random rnd = new Random();
            int winner = rnd.Next(0,registrationNumber);
            return RegisteredContestant[winner];
           

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayWinnerInfo(contestant);
        }
        public void CreateAContestant()
        {
            Contestant contestant = new Contestant(registrationNumber);
            UserInterface.ContestantCreator(contestant);

        }
    }
}
