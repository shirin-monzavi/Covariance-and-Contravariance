namespace Covariance_and_Contravariance_Test
{
    public class Rectangle : Shape
    {
        public override Shape Create()
        {
            return new Rectangle();
        }

        public override Shape Create1(IComparer<Rectangle> rectangle)
        {
            return new Rectangle();
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
                throw new Exception();
            }
            return x;
        }
    }
}
