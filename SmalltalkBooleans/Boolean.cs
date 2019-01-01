using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmalltalkBooleans
{
    public static class Boolean
    {
        private static readonly IDictionary<bool, IBoolean> _boolToBoolean = new Dictionary<bool, IBoolean>
        {
            {true, new True() },
            {false, new False() }
        };

        //bool extensions
        public static IBoolean And(this bool @bool, bool other) =>
           _boolToBoolean[@bool].And(_boolToBoolean[other]);

        public static IBoolean Not(this bool @bool) =>
            _boolToBoolean[@bool].Not();

        public static IBoolean Or(this bool @bool, bool other) =>
            _boolToBoolean[@bool].Or(_boolToBoolean[other]);

        public static IBoolean IfFalse(this bool @bool, Action action) =>
            _boolToBoolean[@bool].IfFalse(action);

        public static IBoolean IfTrue(this bool @bool, Action action) =>
            _boolToBoolean[@bool].IfTrue(action);

        //boolean extensions
        public static IBoolean And(this IBoolean boolean, bool other) =>
            boolean.And(_boolToBoolean[other]);

        public static IBoolean Not(this IBoolean boolean, bool other) =>
            boolean.Not();

        public static IBoolean Or(this IBoolean boolean, bool other) =>
            boolean.Or(_boolToBoolean[other]);

        public static IBoolean IfFalse(this IBoolean boolean, Action action) =>
            boolean.IfFalse(action);

        public static IBoolean IfTrue(this IBoolean boolean, Action action) =>
            boolean.IfTrue(action);
    }
}
