using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Core
    {
        public /*string*/bool TestOfTriangle(double a, double b, double c)
        {
            try
            {
                if (a < b + c)
                {
                    if (b < a + c)
                    {
                        if (c < a + b)
                        {
                            return true;//"Треугольник может существовать";
                        }
                        else return false;// "Треугольник не может существавать, C>A+B";
                    }
                    else return false;//"Треугольник не может существавать, B>A+C";
                }
                else return false;// "Треугольник не может существавать, A>B+C";
            }
            catch
            {
                return false;// "Вводите только цифры. Например: 5.65";
            }
        }
    }
}
