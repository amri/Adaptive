using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDependency
{
    class Adapter : IAdapter
    {
        private Target target;

        public Adapter(Target target)
        {
            this.target = target;
        }

        public string MethodA()
        {
            string methodB = target.MethodB();

            return methodB;
        }
    }
}
