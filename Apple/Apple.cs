/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using IWormNamespace;

namespace Fruits
{
    public class Apple
    {
        private Boolean mRotten;
        private IWormNamespace.IWorm mWorm;
        public Apple(IWorm worm)    // Dependency Injection of IWorm into Apple
        {
            // Instead of the Apple object instantiating a Worm object, it's
            //  passed to the constructor. 
            // AND worm is any class that implements the IWorm Interface 
            //  rather than a specific class.
            mWorm = worm;
            mRotten = false;
        }
        public void MakeRotten() { mRotten = true; }
        public Boolean IsRotten() { return mRotten; }
    }
}
