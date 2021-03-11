using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degrees_Convertor
{
    class Degrees
    {
        public double CelToFahr(double val)
        {
            return (val * 9 / 5) + 32;
        }

        public double FahrToCel(double val)
        {
            return (val - 32) * 5 / 9;
        }
    }
}
