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
            switch (response)
            {
                case "stack":
                    manager = new StackManager();
                    break;

                case "queue":
                    manager = new QueueManager();
                    break;
                default:
                    SetDatabase();
                    break;
            }
        }
            
    }
}