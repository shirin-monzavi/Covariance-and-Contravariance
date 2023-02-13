using System.Collections;

namespace Covariance_and_Contravariance_Test
{
    public class Square : Shape
    {
        public override Square Create()
        {
            return new Square();
        }

        public override Shape Create1(IComparer<Rectangle> rectangle)
        {
            return new Square();
        }

        public override Shape Create2(IContravarient<Rectangle> rectangle)
        {
            throw new NotImplementedException();
        }

        public override Shape Create3(Action<Rectangle> rectangle)
        {
            throw new NotImplementedException();
        }

        public override int CalcWith(int x)
        {
            if (x == 6)
            {
                throw new ArgumentExceptionCustom();
            }
            return x;
        }
    }
}
