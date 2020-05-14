using Calculator;
using Xunit;

namespace XUnitTestProject
{
    public class TestLevenstein
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(3, Levenstein.LevensteinDynamic("Вар", "Баран"));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(4, Levenstein.LevensteinDynamic("test", ""));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(4, Levenstein.LevensteinDynamic("", "test"));
        }
    }  
}
