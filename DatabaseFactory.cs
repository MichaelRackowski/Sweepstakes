using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class DatabaseFactory
    {
        public ISweepstakesManager manager;
        public void SetDatabase()
        {
           string response = UserInterface.DatabaseFinder();
            switch(response)
            {
                case "Stack":
                    manager = new StackManager();
                   break;

                case "Queue":
                    manager = new QueueManager();
                    break;
                default:
                    SetDatabase();
                  break;
            }

            
    }
}