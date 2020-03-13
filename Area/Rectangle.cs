using System;

namespace Area
{
	public class Rectangle : Figure
	{
		public int FirstSide { get; set; }
		public int SecondSide { get; set; }
		public int ThirdSide { get; set; }

		public Rectangle(int firstSide, int secondSide, int thirdSide)
		{
			if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
			{
				throw new Exception("Ни одна из сторон треугольника не может быть меньше или равна 0");
			}
			FirstSide = firstSide;
			SecondSide = secondSide;
			ThirdSide = thirdSide;
		}

		public override double CalculateArea()
		{
			double halfOfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
			return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - FirstSide) * (halfOfPerimeter - SecondSide) * (halfOfPerimeter - ThirdSide));
		}

		public bool IsRightTriangle()
		{
			if (FirstSide > SecondSide && FirstSide > ThirdSide)
			{
				return CheckPythagorasTheorem(FirstSide, SecondSide, ThirdSide);
			}

			if (SecondSide > FirstSide && SecondSide > ThirdSide)
			{
				return CheckPythagorasTheorem(SecondSide, FirstSide, ThirdSide);
			}

			if (ThirdSide > FirstSide && ThirdSide > SecondSide)
			{
				return CheckPythagorasTheorem(ThirdSide, FirstSide, SecondSide);
			}

			return false;
		}

		private bool CheckPythagorasTheorem(int longestSide, int secondSide, int thirdSide)
		{
			return Math.Pow(longestSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2);
		}
	}
}
