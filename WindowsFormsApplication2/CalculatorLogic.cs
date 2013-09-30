using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTestDemoApp
{
    public class CalculatorLogic
    {
        #region Calculator Methods

        public static decimal add(decimal n, decimal m)
        {
            return (n + m);
        }

        public static decimal subtract(decimal n, decimal m)
        {
            return (n + m);
        }

        public static decimal multiply(decimal n, decimal m)
        {
            return (n * m);
        }

        public static decimal divide(decimal n, decimal m)
        {
            return (m / n);
        }

        public static decimal modulo(decimal n, decimal m)
        {
            return (n % m);
        }

        #endregion
    }
}
