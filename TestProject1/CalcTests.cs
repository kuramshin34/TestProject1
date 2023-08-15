namespace TestProject1
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void RightTriangle_3_4_5_true()
        {
            Triangle rightTriangle = new Triangle(3, 4, 5);
            Assert.IsTrue(rightTriangle.IsRightTriangle());

            Triangle notRightTriangle = new Triangle(3, 4, 6);
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
            Triangle triangle = new Triangle(x, y, z);
            double expected = 6;
            double result = triangle.CalculateArea();
            Assert.AreEqual(expected, result);
        }
    }
}