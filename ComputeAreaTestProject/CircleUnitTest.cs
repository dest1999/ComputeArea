using ComputeArea;
using Xunit;

namespace ComputeAreaTestProject
{
    public class CircleUnitTest
    {
        [Fact]
        public void Input2dot5Expect19dot6()
        {
            var circle = new Circle(2.5);

            var actual = circle.Area();
            double expected = 19.625; // посчитано вручную, значение пи - 3.14

            Assert.Equal(actual, expected, 1);
        }


        [Fact]
        public void InputLessZeroValue_ExpectedArgumentExeption()
        {
            var actualExeption = Assert.Throws<ArgumentException>(() => new Circle(-2.5));

            Assert.IsType<ArgumentException>(actualExeption);

        }

    }
}