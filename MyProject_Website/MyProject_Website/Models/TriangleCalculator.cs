using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject_Website.Models
{
    public class TriangleCalculator
    {

        public double Value { get; set; }

        public static double Calculate(double number)
        {
            
            double result = Math.Cos(number);

            return result;
        }


    }

    

}