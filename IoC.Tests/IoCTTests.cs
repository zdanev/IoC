using System;
using Xunit;

namespace IoC.Tests
{
    public class IoCTests
    {
        public interface IService1
        {

        }

        public class Service1: IService1
        {

        }

        [Fact]
        public void Test1()
        {
            // arrange
            var container = new Container();
            container.Register<IService1, Service1>();

            // act
            var service1 = container.Resolve<IService1>();

            // assert
            Assert.True(service1 is Service1);
        }
    }
}