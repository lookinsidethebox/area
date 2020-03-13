using System;
using System.Collections.Generic;

namespace Area
{
	/// <summary>
	/// Фигура без знания типа фигуры (многоугольник)
	/// </summary>
	public class Polygon : Figure
	{
		/// <summary>
		/// Координаты всех вершин многоугольника
		/// </summary>
		public List<Vertex> Vertexes { get; set; }

		public Polygon(List<Vertex> vertexes)
		{
			if (vertexes == null || vertexes.Count < 3)
			{
				throw new Exception("Количество вершин не может быть меньше 3");
			}
			Vertexes = vertexes;
		}

		public override double CalculateArea()
		{
			double result = 0;
			for (var i = 0; i < Vertexes.Count - 1; i++)
			{
				result += (Vertexes[i].X + Vertexes[i + 1].X) * (Vertexes[i + 1].Y - Vertexes[i].Y);
			}
			result += (Vertexes[Vertexes.Count - 1].X + Vertexes[0].X) * (Vertexes[0].Y - Vertexes[Vertexes.Count - 1].Y);
			return result / 2;
		}
	}

	public class Vertex
	{
		public double X { get; set; }
		public double Y { get; set; }
	}
}
