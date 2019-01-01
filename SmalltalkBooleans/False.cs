using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmalltalkBooleans
{
    public class False : IBoolean
    {
        public IBoolean And(IBoolean other) => this;

        public IBoolean Not() => new True();

        public IBoolean Or(IBoolean other) => other;

        public IBoolean IfFalse(Action action)
        {
            action();
            return this;
        }

        public IBoolean IfTrue(Action action) => this;
    }
}
