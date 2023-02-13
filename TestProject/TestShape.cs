using Covariance_and_Contravariance_Test;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public abstract class TestShape<T>  where T : Shape
    {
        private T CreateShape()
        {
            var res =  (T)Activator.CreateInstance(typeof(T));
            return res;
        }

        [Fact]
        public void Test1()
        {
            var shape = CreateShape();
            Assert.Equal(5, shape.CalcWith(5));
        }


        //[Fact]
        //public void Test2()
        //{
        //    var shape = CreateShape();
        //    Assert.Equal(5, shape.CalcWith(5));
        //}

        [Fact]
        public void Test3()
        {
            var shape = CreateShape();
       
            Assert.ThrowsAny<ArgumentException>(() => shape.CalcWith(6));
        }
    }
}
