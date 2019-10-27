using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruits
{
    public class Apple
    {
        private Boolean mRotten;
        public Apple()
        {
            mRotten = false;
        }
        public void MakeRotten() { mRotten = true; }
        public Boolean IsRotten() { return mRotten; }
    }
}
