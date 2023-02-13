using Covariance_and_Contravariance_Test;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var sut = new Rectangle();

            //var mock = new Mock<Shape>();
            //sut.Create1(mock.Object);

            sut.Create1(new Mock<IComparer<Shape>>().Object);
        }

        //[Fact]
        //public void Test2()
        //{
        //    var sut = new Rectangle();


        //    sut.Create2(new Mock<IContravarient<Shape>>().Object);
        //}

        //[Fact]
        //public void Test3()
        //{
        //    var sut = new Rectangle();

        //    Action<Shape> action = (a) => { };

        //    sut.Create3(action);
        //}

        
    }
}