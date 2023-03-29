using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Addition
    {
        public void Add(int x, int y) { }//called function-1
        public void Add(int x, int y, int z) { }//called function-2
        public void Add(int x, int y, long z) { }
        public void Add(int x, long y, int z) { }//called function-3
    }
}
