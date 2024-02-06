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

  

    }
}