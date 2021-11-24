using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHW9
{
    public class Triangle
    {
        private double _a;
        private double _b;
        private double _c;

        public double A
        {
            get
            {
                return _a;
            }
            set
            {
                if(value > 0)
                {
                    _a = value;
                }
                else
                {
                    throw new ArgumentException
                        ("Invalid side value!");
                }
            }
        }

        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                if (value > 0)
                {
                    _b = value;
                }
                else
                {
                    throw new ArgumentException
                        ("Invalid side value!");
                }
            }
        }

        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                if (value > 0)
                {
                    _c = value;
                }
                else
                {
                    throw new ArgumentException
                        ("Invalid side value!");
                }
            }
        }

        public double Perimetr
        {
            get
            {
                return _a + _b + _c;
            }
        }

        public Triangle()
        {
            _a = 1;
            _b = 1;
            _c = 1;
        }

        public Triangle(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public static int GetAnglesSumm()
        {
            return 180;
        }
    }
}
