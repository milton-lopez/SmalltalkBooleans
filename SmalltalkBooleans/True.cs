using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmalltalkBooleans
{
    public class True : IBoolean
    {
        public IBoolean And(IBoolean other) => other;

        public IBoolean Or(IBoolean other) => this;

        public IBoolean Not() => new False();

        public IBoolean IfFalse(Action action) => this;

        public IBoolean IfTrue(Action action)
        {
            action();
            return this;
        }
    }
}
