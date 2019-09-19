using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseFactory data = new DatabaseFactory();
            data.SetDatabase();
            MarketingFirm firm = new MarketingFirm(data.manager);
            firm.makeSweepstakes();
        }

        

    }
}
