using LinesLib;
namespace LineSegmentTests

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToStringTest()
        {
            // arrange
            var LineSegment = new LineSegment(2, 7);


            // act
            var result = LineSegment.ToString();

            // assert
            Assert.AreEqual("2..7", result);
        }


        [TestMethod]
        public void ContainsTest()
        {
            // arrange
            var LineSegment = new LineSegment(0, 5);
            // act
            int pointWithin = 3;
            Assert.IsTrue(LineSegment.Contains(pointWithin), "Point should be within the line segment");

            // assert.
            int pointOutside = -1;
            Assert.IsFalse(LineSegment.Contains(pointOutside), "Point should be outside the line segment");
        }
  

    }
}