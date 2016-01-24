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

        public string message { get; set; }

        public static TriangleCalculator Calculate(TriangleCalculator calc)
        {
            calc.message = "Ok";

            if (calc.sideA > 0 && calc.sideB > 0 && calc.sideC > 0)
            {
                var cosA = (Math.Pow(calc.sideB, 2) + Math.Pow(calc.sideC, 2) - Math.Pow(calc.sideA, 2)) / (2 * calc.sideB * calc.sideC);
                calc.angleA = Math.Round(RadianToDegree(Math.Acos(cosA)), 2);

                var cosB = (Math.Pow(calc.sideA, 2) + Math.Pow(calc.sideC, 2) - Math.Pow(calc.sideB, 2)) / (2 * calc.sideA * calc.sideC);
                calc.angleB = Math.Round(RadianToDegree(Math.Acos(cosB)), 2);

                calc.angleC = Math.Round(180 - calc.angleA - calc.angleB, 2);

                return calc;
            }
            else if (calc.sideA > 0 && calc.angleC > 0 && calc.sideB > 0)
            {
                calc.sideC = Math.Round(Math.Sqrt(Math.Pow(calc.sideA, 2) + Math.Pow(calc.sideB, 2) - 2 * calc.sideA * calc.sideB * Math.Cos(DegreeToRadian(calc.angleC))), 2);

                var cosA = (Math.Pow(calc.sideB, 2) + Math.Pow(calc.sideC, 2) - Math.Pow(calc.sideA, 2)) / (2 * calc.sideB * calc.sideC);
                calc.angleA = Math.Round(RadianToDegree(Math.Acos(cosA)), 2);

                calc.angleB = Math.Round(180 - calc.angleC - calc.angleA, 2);

                return calc;
            }
            else if (calc.angleA > 0 && calc.sideB > 0 && calc.angleC > 0)
            {
                calc.angleB = Math.Round(180 - calc.angleC - calc.angleA, 2);

                calc.sideA = Math.Round((calc.sideB * Math.Sin(DegreeToRadian(calc.angleA))) / Math.Sin(DegreeToRadian(calc.angleB)), 2);

                calc.sideC = Math.Round(Math.Sqrt(Math.Pow(calc.sideA, 2) + Math.Pow(calc.sideB, 2) - 2 * calc.sideA * calc.sideB * Math.Cos(DegreeToRadian(calc.angleC))), 2);

                return calc;
            }
            else if (calc.angleB > 0 && calc.sideB > 0 && calc.angleA > 0)
            {
                calc.angleC = Math.Round(180 - calc.angleB - calc.angleA, 2);

                calc.sideA = Math.Round((calc.sideB * Math.Sin(DegreeToRadian(calc.angleA))) / Math.Sin(DegreeToRadian(calc.angleB)), 2);

                calc.sideC = Math.Round(Math.Sqrt(Math.Pow(calc.sideA, 2) + Math.Pow(calc.sideB, 2) - 2 * calc.sideA * calc.sideB * Math.Cos(DegreeToRadian(calc.angleC))), 2);

                return calc;
            }
            else if (calc.sideB > 0 && calc.angleB > 0 && calc.sideA > 0)
            {
                var sinA = (calc.sideA / calc.sideB) * Math.Sin(DegreeToRadian(calc.angleB));
                calc.angleA = Math.Round(RadianToDegree(Math.Asin(sinA)), 2);

                calc.angleC = Math.Round(180 - calc.angleB - calc.angleA, 2);

                calc.sideC = Math.Round((calc.sideB * Math.Sin(DegreeToRadian(calc.angleC))) / Math.Sin(DegreeToRadian(calc.angleB)), 2);

                return calc;
            }
            else if (calc.angleB > 0 && calc.sideC > 0 && calc.angleA > 0)
            {
                calc.angleC = Math.Round(180 - calc.angleB - calc.angleA, 2);

                calc.sideA = Math.Round((calc.sideC * Math.Sin(DegreeToRadian(calc.angleA))) / Math.Sin(DegreeToRadian(calc.angleC)), 2);

                calc.sideB = Math.Round((calc.sideC * Math.Sin(DegreeToRadian(calc.angleB))) / Math.Sin(DegreeToRadian(calc.angleC)), 2);

                return calc;
            }
            else if (calc.sideB > 0 && calc.angleA > 0 && calc.sideA > 0)
            {
                var sinB = (calc.sideB / calc.sideA) * Math.Sin(DegreeToRadian(calc.angleA));
                calc.angleB = Math.Round(RadianToDegree(Math.Asin(sinB)), 2);

                calc.angleC = Math.Round(180 - calc.angleB - calc.angleA, 2);

                calc.sideC = Math.Round((calc.sideB * Math.Sin(DegreeToRadian(calc.angleC))) / Math.Sin(DegreeToRadian(calc.angleB)), 2);

                return calc;
            }
            else if (calc.angleA > 0 && calc.sideA > 0 && calc.angleB > 0)
            {
                calc.angleC = Math.Round(180 - calc.angleB - calc.angleA, 2);

                calc.sideC = Math.Round((calc.sideA * Math.Sin(DegreeToRadian(calc.angleC))) / Math.Sin(DegreeToRadian(calc.angleA)), 2);

                calc.sideB = Math.Round((calc.sideA * Math.Sin(DegreeToRadian(calc.angleB))) / Math.Sin(DegreeToRadian(calc.angleA)), 2);

                return calc;
            }
            else if (calc.sideB > 0 && calc.angleB > 0 && calc.sideC > 0)
            {
                var sinC = (calc.sideC / calc.sideB) * Math.Sin(DegreeToRadian(calc.angleB));
                calc.angleC = Math.Round(RadianToDegree(Math.Asin(sinC)), 2);

                calc.angleA = Math.Round(180 - calc.angleB - calc.angleC, 2);

                calc.sideA = Math.Round((calc.sideB * Math.Sin(DegreeToRadian(calc.angleA))) / Math.Sin(DegreeToRadian(calc.angleB)), 2);

                return calc;
            }
            else if (calc.angleB > 0 && calc.sideB > 0 && calc.angleC > 0)
            {
                calc.angleA = Math.Round(180 - calc.angleC - calc.angleB, 2);

                calc.sideA = Math.Round((calc.sideB * Math.Sin(DegreeToRadian(calc.angleA))) / Math.Sin(DegreeToRadian(calc.angleB)), 2);

                calc.sideC = Math.Round((calc.sideB * Math.Sin(DegreeToRadian(calc.angleC))) / Math.Sin(DegreeToRadian(calc.angleB)), 2);

                return calc;
            }
            else if (calc.sideC > 0 && calc.angleA > 0 && calc.sideB > 0)
            {
                calc.sideA = Math.Round(Math.Sqrt(Math.Pow(calc.sideB, 2) + Math.Pow(calc.sideC, 2) - 2 * calc.sideB * calc.sideC * Math.Cos(DegreeToRadian(calc.angleA))), 2);

                var sinC = (calc.sideC / calc.sideA) * Math.Sin(DegreeToRadian(calc.angleA));
                calc.angleC = Math.Round(RadianToDegree(Math.Asin(sinC)), 2);

                calc.angleB = Math.Round(180 - calc.angleA - calc.angleC, 2);

                return calc;
            }
            else if (calc.angleC > 0 && calc.sideA > 0 && calc.angleB > 0)
            {
                calc.angleA = Math.Round(180 - calc.angleC - calc.angleB, 2);

                calc.sideB = Math.Round((calc.sideA * Math.Sin(DegreeToRadian(calc.angleB))) / Math.Sin(DegreeToRadian(calc.angleA)), 2);

                calc.sideC = Math.Round((calc.sideA * Math.Sin(DegreeToRadian(calc.angleC))) / Math.Sin(DegreeToRadian(calc.angleA)), 2);

                return calc;
            }
            else if (calc.angleC > 0 && calc.sideA > 0 && calc.angleA > 0)
            {
                calc.angleB = Math.Round(180 - calc.angleC - calc.angleA, 2);

                calc.sideB = Math.Round((calc.sideA * Math.Sin(DegreeToRadian(calc.angleB))) / Math.Sin(DegreeToRadian(calc.angleA)), 2);

                calc.sideC = Math.Round(Math.Sqrt(Math.Pow(calc.sideA, 2) + Math.Pow(calc.sideB, 2) - 2 * calc.sideA * calc.sideB * Math.Cos(DegreeToRadian(calc.angleC))), 2);

                return calc;
            }
            else if (calc.sideC > 0 && calc.angleA > 0 && calc.sideA > 0)
            {
                var sinC = (calc.sideC / calc.sideA) * Math.Sin(DegreeToRadian(calc.angleA));
                calc.angleC = Math.Round(RadianToDegree(Math.Asin(sinC)), 2);

                calc.angleB = Math.Round(180 - calc.angleA - calc.angleC, 2);

                calc.sideB = Math.Round((calc.sideA * Math.Sin(DegreeToRadian(calc.angleB))) / Math.Sin(DegreeToRadian(calc.angleA)), 2);

                return calc;
            }
            else if (calc.sideC > 0 && calc.angleC > 0 && calc.sideA > 0)
            {
                var sinA = (calc.sideA / calc.sideC) * Math.Sin(DegreeToRadian(calc.angleC));
                calc.angleA = Math.Round(RadianToDegree(Math.Asin(sinA)), 2);

                calc.angleB = Math.Round(180 - calc.angleA - calc.angleC, 2);

                calc.sideB = Math.Round((calc.sideA * Math.Sin(DegreeToRadian(calc.angleB))) / Math.Sin(DegreeToRadian(calc.angleA)), 2);

                return calc;
            }
            else if (calc.sideC > 0 && calc.angleB > 0 && calc.sideA > 0)
            {
                calc.sideB = Math.Round(Math.Sqrt(Math.Pow(calc.sideA, 2) + Math.Pow(calc.sideC, 2) - 2 * calc.sideA * calc.sideC * Math.Cos(DegreeToRadian(calc.angleB))), 2);

                var sinC = (calc.sideC / calc.sideB) * Math.Sin(DegreeToRadian(calc.angleB));
                calc.angleC = Math.Round(RadianToDegree(Math.Asin(sinC)), 2);

                calc.angleA = Math.Round(180 - calc.angleB - calc.angleC, 2);

                return calc;
            }
            else if (calc.sideC > 0 && calc.angleA > 0 && calc.sideB > 0)
            {
                calc.sideA = Math.Round(Math.Sqrt(Math.Pow(calc.sideB, 2) + Math.Pow(calc.sideC, 2) - 2 * calc.sideB * calc.sideC * Math.Cos(DegreeToRadian(calc.angleA))), 2);

                var sinC = (calc.sideC / calc.sideA) * Math.Sin(DegreeToRadian(calc.angleA));
                calc.angleC = Math.Round(RadianToDegree(Math.Asin(sinC)), 2);

                calc.angleB = Math.Round(180 - calc.angleA - calc.angleC, 2);

                return calc;
            }
            else if (calc.angleC > 0 && calc.sideA > 0 && calc.angleB > 0)
            {
                calc.angleA = Math.Round(180 - calc.angleC - calc.angleB, 2);

                calc.sideB = Math.Round((calc.sideA * Math.Sin(DegreeToRadian(calc.angleB))) / Math.Sin(DegreeToRadian(calc.angleA)), 2);

                calc.sideC = Math.Round(Math.Sqrt(Math.Pow(calc.sideA, 2) + Math.Pow(calc.sideB, 2) - 2 * calc.sideA * calc.sideB * Math.Cos(DegreeToRadian(calc.angleC))), 2);

                return calc;
            }
            else if (calc.angleC > 0 && calc.sideA > 0 && calc.angleA > 0)
            {
                calc.angleB = Math.Round(180 - calc.angleC - calc.angleA, 2);

                calc.sideB = Math.Round((calc.sideA * Math.Sin(DegreeToRadian(calc.angleB))) / Math.Sin(DegreeToRadian(calc.angleA)), 2);

                calc.sideC = Math.Round(Math.Sqrt(Math.Pow(calc.sideA, 2) + Math.Pow(calc.sideB, 2) - 2 * calc.sideA * calc.sideB * Math.Cos(DegreeToRadian(calc.angleC))), 2);

                return calc;
            }
            else if (calc.sideC > 0 && calc.angleA > 0 && calc.sideA > 0)
            {
                var sinC = (calc.sideC / calc.sideA) * Math.Sin(DegreeToRadian(calc.angleA));
                calc.angleC = Math.Round(RadianToDegree(Math.Asin(sinC)), 2);

                calc.angleB = Math.Round(180 - calc.angleA - calc.angleC, 2);

                calc.sideB = Math.Round((calc.sideA * Math.Sin(DegreeToRadian(calc.angleB))) / Math.Sin(DegreeToRadian(calc.angleA)), 2);

                return calc;
            }
            else
            {
                calc.message = "Please only fill out three values";
            }

            return calc;
        }

        public static double RadianToDegree(double value)
        {
            return (180 / Math.PI) * value;
        }

        public static double DegreeToRadian(double value)
        {
            return value * (Math.PI / 180.0);
        }
    }
}