using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Area.Tests
{
	[TestClass]
	public class CircleTests
	{
		[TestMethod]
		public void Circle()
		{
			Assert.ThrowsException<Exception>(() => new Circle(-10));
		}

		[TestMethod]
		public void CalculateArea()
		{
			var actual = new Circle(10).CalculateArea();
			var expected = Math.PI * 100;
			Assert.AreEqual(expected, actual);
		}
	}
}
