using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using Xunit;
using Xunit.Abstractions;


namespace GitHub.TestLogger.Example.UnitTests {
    public class SimpleTest {

        public SimpleTest() { }

        [Fact]
        public void FactTestSuccess() {
            var value = 1;
            Assert.Equal(1, value);
        }

        private void FactTestFailureMoreStackDepth2() {
            var value = 2;
            Assert.Equal(1, value);
        }

        private void FactTestFailureMoreStackDepth1() {
            FactTestFailureMoreStackDepth2();
        }

        [Fact]
        public void FactTestFailure() {
            FactTestFailureMoreStackDepth1();
        }


    }
}
