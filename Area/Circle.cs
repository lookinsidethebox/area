using System;

namespace Area
{
	public class Circle : Figure
	{
		public double Radius { get; set; }

		public Circle(double radius)
		{
			if (radius <= 0)
			{
				throw new Exception("Радиус не может быть меньше или равен 0");
			}
			Radius = radius;
		}

		public override double CalculateArea()
		{
			return Math.PI * Math.Pow(Radius, 2);
		}
	}
}
