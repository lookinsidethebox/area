using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Area.Tests
{
	[TestClass]
	public class RectangleTests
	{
		[TestMethod]
		public void Rectangle()
		{
			Assert.ThrowsException<Exception>(() => new Rectangle(-10, 5, 10));

			Assert.ThrowsException<Exception>(() => new Rectangle(5, 10, 20));
		}

		[TestMethod]
		public void CalculateArea()
		{
			var actual = new Rectangle(2, 8, 7).CalculateArea();
			var expected = 6.437197;
			Assert.AreEqual(expected, Math.Round(actual, 6));
		}

		[TestMethod]
		public void IsRightTriangle()
		{
			var actual = new Rectangle(3, 4, 5).IsRightTriangle();
			var expected = true;
			Assert.AreEqual(expected, actual);

			actual = new Rectangle(3, 4, 6).IsRightTriangle();
			expected = false;
			Assert.AreEqual(expected, actual);
		}
	}
}
