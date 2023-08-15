namespace TestProject1
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void RightTriangle_3_4_5_true()
        {
            //arrange
            double x = 3;
            double y = 4;
            double z = 5;
            Triangle rightTriangle = new Triangle(x, y, z);
            Assert.IsTrue(rightTriangle.IsRightTriangle());

            z = 6;
            Triangle notRightTriangle = new Triangle(x, y, z);
            Assert.IsFalse(notRightTriangle.IsRightTriangle());
        }

        [TestMethod]
        public void CalcCircle_5_150returned()
        {
            //arrange
            int x = 5;
            double expected = Math.PI * 25;
            //actian
            Circle c = new Circle(x);
            double ac = c.CalculateArea();
            //assert
            Assert.AreEqual(expected, ac);
        }
        [TestMethod]
        public void CaclTriangle_3_4_5_6returned()
        {
            //arrange
            double x = 3;
            double y = 4;
            double z = 5;
            double expected = 6;
            //actian
            Triangle triangle = new Triangle(x, y, z);
            double result = triangle.CalculateArea();
            //assert
            Assert.AreEqual(expected, result);
        }
    }
}