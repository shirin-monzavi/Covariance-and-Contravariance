using System.Collections;

namespace Covariance_and_Contravariance_Test
{
    public abstract class Shape
    {
        public abstract Shape Create();

        public abstract Shape Create1(IComparer<Rectangle> rectangle);

        public abstract Shape Create2(IContravarient<Rectangle> rectangle);

        public abstract Shape Create3(Action<Rectangle> rectangle);

        public virtual int CalcWith(int x)
        {
            if (x == 6)
            {
                throw new ArgumentException();
            }
            return x;
        }
    }
}