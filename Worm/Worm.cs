using IWormNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WormNamespace
{
    public class Worm: IWorm
    {
        public void Infest()
        {
            Console.WriteLine("Worm is infesting apple...");
        }


    }
}
