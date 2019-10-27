using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWormNamespace;

namespace Fruits
{
    public class Apple
    {
        private Boolean mRotten;
        private IWormNamespace.IWorm mWorm;
        public Apple(IWorm worm)    // Dependency Injection of IWorm into Apple
        {
            mRotten = false;
            mWorm = worm;
        }
        public void MakeRotten() { mRotten = true; }
        public Boolean IsRotten() { return mRotten; }
    }
}
