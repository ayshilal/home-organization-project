using System;
using C2T.WebApi.Controllers;
using Xunit;

namespace C2T.UnitTest
{
    public class UnitTest1
    {
        private readonly ValuesController _controller = new ValuesController();
        [Fact]
        public string Test1()
        {
             _controller.Get();
            return ToString();
        }
    }
}