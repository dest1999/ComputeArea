using ComputeArea;
using Xunit;

namespace ComputeAreaTestProject
{
    public class CircleUnitTest
    {
        [Fact]
        public void Input2dot5Expect19dot6()
        {
            //arrange
            var circle = new Circle(2.5);

            //act
            var actual = circle.Area();
            double expected = 19.625; // посчитано вручную, значение пи - 3.14

            //assert
            Assert.Equal(actual, expected, 1);

        }


        [Fact]
        public void InputLessZeroValue_ExpectedArgumentExeption()
        {
            var actualExeption = Assert.Throws<ArgumentException>(() => new Circle(-2.5));

            Assert.IsType<ArgumentException>(actualExeption);

        }

        [Fact]
        public void InputGreaterThanMaxValue_ExpectedArgumentExeption()
        {
            var actualExeption = Assert.Throws<ArgumentException>(() => new Circle(double.MaxValue + 1.1));

            Assert.IsType<ArgumentException>(actualExeption);

        }
    }
}