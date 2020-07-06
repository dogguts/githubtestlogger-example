using DogGuts.Calculator;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using Xunit;
using Xunit.Abstractions;


namespace GitHub.TestLogger.Example.UnitTests {

    public class CalculatorTest {

        private readonly ITestOutputHelper _outputHelper;
        private readonly Calculator _calculator;
        public CalculatorTest(ITestOutputHelper outputHelper) {
            _outputHelper = outputHelper;
            _calculator = new Calculator();
        }

        [Fact]
        public void Add() {
            Assert.Equal(5, _calculator.Add(2, 3));
        }

        [Fact]
        private void Division() {
            Assert.Equal(5, _calculator.Division(10, 2));
        }

        [Fact]
        public void Multiply() {
            Assert.Equal(10, _calculator.Multiply(2, 5));
        }

        [Fact]
        public void Square() {
            Assert.Equal(9, _calculator.Square(3));
        }

        [Fact]
        public void Subtract() {
            Assert.Equal(9, _calculator.Subtract(12, 3));
        }

        [Fact]
        public void PositiveDivisionByZeroEqualsPositiveInfinity() {
            Assert.Equal(float.PositiveInfinity, _calculator.Division(10, 0));
        }

        [Fact]
        public void NegativeDivisionByZeroEqualsNegativeInfinity() {
            Assert.Equal(float.NegativeInfinity, _calculator.Division(-10, 0));
        }

        [Fact]
        public void DeliberateTestFailure() {
            _outputHelper.WriteLine("Let's put some extra output here.");
            _outputHelper.WriteLine("This test is set to deliberately fail, as an example.");
            Assert.Equal(42, _calculator.Add(22, 22));
        }

    }
}

