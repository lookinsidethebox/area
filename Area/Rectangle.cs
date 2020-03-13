using System;

namespace Area
{
	public class Rectangle : Figure
	{
		public double FirstSide { get; set; }
		public double SecondSide { get; set; }
		public double ThirdSide { get; set; }

		public Rectangle(double firstSide, double secondSide, double thirdSide)
		{
			if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
			{
				throw new Exception("Ни одна из сторон треугольника не может быть меньше или равна 0");
			}

			if (firstSide >= secondSide + thirdSide ||
				secondSide >= firstSide + thirdSide ||
				thirdSide >= firstSide + secondSide)
			{
				throw new Exception("Одна сторона треугольника больше суммы двух других сторон - такого треугольника не существует");
			}

			FirstSide = firstSide;
			SecondSide = secondSide;
			ThirdSide = thirdSide;
		}

		public override double CalculateArea()
		{
			var halfOfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
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

		private bool CheckPythagorasTheorem(double longestSide, double secondSide, double thirdSide)
		{
			return Math.Pow(longestSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2);
		}
	}
}
