using System;
using CalculatorLib;
using Xunit;

namespace CalculatorLibUnitTests {
    public class UnitTest1 {
        [Fact]
        public void Test_Adding_2_And_2() {
            // arrange
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new Calculator();

            // act
            double actual = calc.Add(a, b);

            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test_Adding_2_And_3() {
            // arrange
            double a = 2;
            double b = 3;
            double expected = 5;
            var calc = new Calculator();

            // act
            double actual = calc.Add(a, b);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}