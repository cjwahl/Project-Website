using System;

namespace MyProject_Website.Models
{
    public class TriangleCalculator
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }
        public double angleA { get; set; }
        public double angleB { get; set; }
        public double angleC { get; set; }

        public double Value { get; set; }

        public static TriangleCalculator Calculate(TriangleCalculator calc)
        {
            if (calc.sideA > 0 && calc.sideB > 0 && calc.sideC > 0)
            {
                var cosA = (Math.Pow(calc.sideB, 2) + Math.Pow(calc.sideC, 2) - Math.Pow(calc.sideA, 2)) / (2 * calc.sideB * calc.sideC);
                calc.angleA = Math.Round(RadianToDegree(Math.Acos(cosA)), 2);

                var cosB = (Math.Pow(calc.sideA, 2) + Math.Pow(calc.sideC, 2) - Math.Pow(calc.sideB, 2)) / (2 * calc.sideA * calc.sideC);
                calc.angleB = Math.Round(RadianToDegree(Math.Acos(cosB)), 2);

                calc.angleC = Math.Round(180 - calc.angleA - calc.angleB, 2);

                return calc;
            }
            else if(calc.sideA > 0 && calc.sideB > 0 && calc.angleC > 0)
            {
                return calc;
            }
            return calc;
        }

        public static double RadianToDegree(double value)
        {
            return (180 / Math.PI) * value;
        }
    }
}