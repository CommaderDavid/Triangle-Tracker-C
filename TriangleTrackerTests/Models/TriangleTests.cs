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
            Triangle testTriangleTracker = new Triangle(4, 4, 4);
            Assert.AreEqual("Your triangle is an Equilateral triangle", testTriangleTracker.GetTriangleType());
        }

        [TestMethod]
        public void IsIsosceles_TwoSidesEqual_True()
        {
            Triangle testIsoscelesTriangle = new Triangle(5, 5, 9);
            Assert.AreEqual("Your Triangle is an Isosceles triangle", testIsoscelesTriangle.GetTriangleType());
        }
    }
}

// variableName.MethodName().