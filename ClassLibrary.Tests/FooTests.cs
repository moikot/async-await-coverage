using System;
using System.Threading.Tasks;
using NSubstitute;
using Xunit;

namespace ClassLibrary.Tests
{
    public class FooTests
    {
        [Fact]
        public async Task Test()
        {
            var service = Substitute.For<IService>();
            service.GetCat().Returns("cat");

            var foo = new Foo(service);
            await foo.Bar();

            await service.Received(1).Process("cat");
        }
    }
}
