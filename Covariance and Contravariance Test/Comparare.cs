using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance_and_Contravariance_Test
{
    public class Comparare : IComparer<Shape>
    {
        public int Compare(Shape? x, Shape? y)
        {
            throw new NotImplementedException();
        }
    }
}
