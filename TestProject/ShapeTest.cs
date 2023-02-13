using Covariance_and_Contravariance_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class ShapeTest : Shape
    {
        public override Shape Create()
        {
            throw new NotImplementedException();
        }

        public override Shape Create1(IComparer<Rectangle> rectangle)
        {
            throw new NotImplementedException();
        }

        public override Shape Create2(IContravarient<Rectangle> rectangle)
        {
            throw new NotImplementedException();
        }

        public override Shape Create3(Action<Rectangle> rectangle)
        {
            throw new NotImplementedException();
        }
    }
}
