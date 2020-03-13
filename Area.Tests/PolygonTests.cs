using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Area.Tests
{
	[TestClass]
	public class PolygonTests
	{
		[TestMethod]
		public void Polygon()
		{
			Assert.ThrowsException<Exception>(() => new Polygon(null));
		}

		[TestMethod]
		public void CalculateArea()
		{
			var vertexes = new List<Vertex>
			{
				new Vertex { X = -1, Y = -1 },
				new Vertex { X = -3, Y = 3 },
				new Vertex { X = 1, Y = 4 },
				new Vertex { X = 3, Y = 0 },
				new Vertex { X = 1, Y = -1 }
			};
			var actual = new Polygon(vertexes).CalculateArea();
			var expected = 19;
			Assert.AreEqual(expected, actual);
		}
	}
}
