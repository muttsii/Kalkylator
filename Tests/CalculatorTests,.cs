using Xunit;
using Kalkyl;
using System;

namespace Tests
{
    public class TestCalculator
    {
        [Fact]
        public void AddTest()
        {
            Calculation calculation = new ();
            Assert.Equal(10, calculation.Add(5, 5));
            Assert.Equal(12, calculation.Add(8, 4));
            Assert.NotEqual(11, calculation.Add(5,4));
            Assert.NotEqual(12, calculation.Add(5, 6));
            Assert.NotEqual(8, calculation.Add(5, 4));
        }
        [Fact]
        public void SubTest()
        {
            Calculation calculation = new();
            Assert.Equal(15, calculation.Sub(30, 15));
            Assert.Equal(0, calculation.Sub(12, 12));
            Assert.NotEqual(16, calculation.Sub(12, 4));
            Assert.NotEqual(12, calculation.Sub(17, 6));
            Assert.NotEqual(8, calculation.Sub(3, 1));
        }
        [Fact]
        public void DivTest()
        {
            Calculation calculation = new();
            Assert.Equal(2, calculation.Div(132, 66));
            Assert.Equal(15, calculation.Div(30, 2));
            Assert.Equal(1, calculation.Div(1, 1));
            Assert.NotEqual(2, calculation.Div(3, 1));
            Assert.NotEqual(15, calculation.Div(58, 3));
            Assert.NotEqual(7, calculation.Div(12, 2));
        }
        [Fact]
        public void MulTest()
        {
            Calculation calculation = new();
            Assert.Equal(144, calculation.Mul(12, 12));
            Assert.Equal(49, calculation.Mul(7, 7));
            Assert.Equal(12, calculation.Mul(2, 6));
            Assert.NotEqual(50, calculation.Mul(5, 4));
            Assert.NotEqual(76, calculation.Mul(8, 12));
            Assert.NotEqual(14, calculation.Mul(2, 5));
        }
    }
}