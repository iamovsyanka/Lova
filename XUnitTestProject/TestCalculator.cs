using Calculator;
using Xunit;

namespace XUnitTestProject
{
    public class TestCalculator
    {
        private CalculatorModel calculator = new CalculatorModel();
                     
        [Fact]
        public void TestCantDoOperatorInitially()
        {
            Assert.False(calculator.CanDoSign());
        }        
        
        [Fact]
        public void TestCanDoOperatorAfterNumber()
        {
            calculator.Number(5);
            Assert.True(calculator.CanDoSign());
        }

        [Fact]
        public void TestCantDoOperatorAfterOperator()
        {
            calculator.Number(5);
            calculator.Plus();
            Assert.False(calculator.CanDoSign());
        }

        [Fact]
        public void TestCanDoClear()
        {
            Assert.True(calculator.CanDoClear());
        }

        [Fact]
        public void TestDisplayShouldShowOperator()
        {
            calculator.Number(1);
            calculator.Plus();
            Assert.Equal("1 + ", calculator.Display);
        }

        [Fact]
        public void TestCanDoSubtraction()
        {
            calculator.Number(1);
            calculator.Number(2);
            calculator.Minus();
            calculator.Number(1);
            calculator.Number(3);
            calculator.Equals();
            Assert.Equal(-1, calculator.Result);
        }

        [Fact]
        public void TestCanDoEasyAddition()
        {
            calculator.Number(4);
            calculator.Plus();
            calculator.Number(3);
            calculator.Equals();
            Assert.Equal(7, calculator.Result);
        }

        [Fact]
        public void TestCanDoMultiplication()
        {
            calculator.Number(2);
            calculator.Number(0);
            calculator.Times();
            calculator.Number(3);
            calculator.Number(0);
            calculator.Equals();
            Assert.Equal(600, calculator.Result);
        }

        [Fact]
        public void TestCanDoDivision()
        {
            calculator.Number(4);
            calculator.Over();
            calculator.Number(1);
            calculator.Number(0);
            calculator.Equals();
            Assert.Equal(0.4, calculator.Result);
        }
    }
}
