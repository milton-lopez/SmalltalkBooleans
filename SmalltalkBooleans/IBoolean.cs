using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmalltalkBooleans
{
    public interface IBoolean
    {
        IBoolean And(IBoolean other);
        IBoolean Or(IBoolean other);
        IBoolean Not();
        IBoolean IfTrue(Action action);
        IBoolean IfFalse(Action action);
    }
}
