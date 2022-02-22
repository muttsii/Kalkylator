using Kalkyl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class TempTests
    {
        [Fact]
        public void TempTestCtoF()
        {
            Temperature temperature = new();
            Assert.Equal(89.6m, temperature.CtoF(32));
            Assert.Equal(10.4m, temperature.CtoF(-12m));
            Assert.Equal(33.8m, temperature.CtoF(1));
            Assert.NotEqual(50.3m, temperature.CtoF(25));
            Assert.NotEqual(100, temperature.CtoF(40));
            Assert.NotEqual(5.5m, temperature.CtoF(-20m));
        }
        [Fact]
        public void TempTestFtoC()
        {
            Temperature temperature = new();
            Assert.Equal(40, temperature.FtoC(104));
            Assert.Equal(31.11m, temperature.FtoC(88));
            Assert.Equal(53, temperature.FtoC(127.4m));
            Assert.NotEqual(50.3m, temperature.FtoC(0));
            Assert.NotEqual(100, temperature.FtoC(126));
            Assert.NotEqual(5.5m, temperature.FtoC(50));
        }
    }
}
