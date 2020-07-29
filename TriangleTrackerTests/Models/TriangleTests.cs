using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTrackerTests
{
    [TestClass]
    public class TriangleTests
    {
        // Test methods go here
        [TestMethod]
        public void IsEquilateral_AllSidesEqual_True()
        {
            // any necessary logic to prep for test; instantiating new classes, etc.
            Triangle testTriangleTracker = new Triangle(4, 5, 9);
            Assert.AreEqual(string, Triangle.GetTriangleType());
        }
    }
}