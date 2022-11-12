using ComputeArea;
using Xunit;

namespace ComputeAreaTestProject
{
    public class TriangleUnitTest
    {
        [Fact]
        public void Input2and3and4Expect2dot9AndNotSquared()
        {
            var triangle = new Triangle(2, 3, 4);

            var actualArea = triangle.Area();
            var actualSqr = triangle.isTriangleSquare();

            double expectedArea = 2.9; // посчитано вручную
            bool expectedSqr = false;

            Assert.Equal(actualArea, expectedArea, 1);
            Assert.Equal(actualSqr, expectedSqr);
        }

        [Fact]
        public void Input6and8and10Expect24AndSquared()
        {
            var triangle = new Triangle(6, 10, 8);

            var actualArea = triangle.Area();
            var actualSqr = triangle.isTriangleSquare();

            double expectedArea = 24; // посчитано вручную
            bool expectedSqr = true;

            Assert.Equal(actualArea, expectedArea, 1);
            Assert.Equal(actualSqr, expectedSqr);
        }

        [Fact]
        public void InputLessZeroValue_ExpectedArgumentExeption()
        {
            var actualExeption = Assert.Throws<ArgumentException>(() => new Triangle(6, -10, 8));

            Assert.IsType<ArgumentException>(actualExeption);

        }

    }
}