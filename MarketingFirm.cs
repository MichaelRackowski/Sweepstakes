using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public ISweepstakesManager manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        public void makeSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.NamingSweepstakes());
            Contestant contestant = sweepstakes.CreateAContestant();
            sweepstakes.RegisterContestant(contestant);
            Contestant contestant1 = sweepstakes.PickWinner();
            sweepstakes.PrintContestantInfo(contestant);
            manager.InsertSweepstakes(sweepstakes);
        }       
    }
}
