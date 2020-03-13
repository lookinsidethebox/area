using Area;
using System;
using System.Collections.Generic;

namespace Main
{
	class Program
	{
		static void Main(string[] args)
		{
			var vertexes = new List<Vertex>
			{
				new Vertex { X = -1, Y = -1 },
				new Vertex { X = -2, Y = 2 },
				new Vertex { X = 1, Y = 4 },
				new Vertex { X = 3, Y = 0 },
				new Vertex { X = 1, Y = -1 }
			};
			var area = new Polygon(vertexes).CalculateArea();
			Console.WriteLine(area);
			Console.ReadLine();
		}
	}
}
