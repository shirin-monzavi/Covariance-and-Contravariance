using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance_and_Contravariance_Test
{
    public class ArgumentExceptionCustom: ArgumentException
    {
        public override string Message => "You cannot enter 6 for width";
    }
}
