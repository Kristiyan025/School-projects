using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpitvane04_03
{
    public abstract class GeometryObject
    {
        public string Name;
        public abstract void Read();
        public abstract void Print();
    }
}
