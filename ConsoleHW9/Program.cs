using System;

namespace ConsoleHW9
{
    class Program
    {
        static CoordinateQuater GetCoordinateQuater(Point point)
        {
            CoordinateQuater result = CoordinateQuater.Zero;
            if (point.X > 0)
            {
                if (point.Y > 0)
                {
                    result = CoordinateQuater.First;
                }
                else if(point.Y < 0)
                {
                    result = CoordinateQuater.Fouth;
                }
            }
            else if(point.X < 0)
            {
                if(point.Y > 0)
                {
                    result = CoordinateQuater.Second;
                }
                else if(point.Y < 0)
                {
                    result = CoordinateQuater.Third;
                }
            }

            return result;
        }

        static void UnitFromAToB()
        {
            Console.Write("Enter base units:");
            string units = Console.ReadLine();
            Enum.TryParse(typeof(WeightsCoefficients), units,
                out var result);
            WeightsCoefficients source = (WeightsCoefficients)result;
            Console.Write("Enter dest units:");
            units = Console.ReadLine();
            Enum.TryParse(typeof(WeightsCoefficients), units,
                out result);
            WeightsCoefficients dest = (WeightsCoefficients)result;
            Console.Write("Enter base value:");
            int baseValue = Convert.ToInt32(Console.ReadLine());

            int res = baseValue * (int)source / (int)dest;
            Console.WriteLine(res);
        }

        static void GetValueFromGramm()
        {
            Console.Write("Enter amount in gramm:");
            int value = Convert.ToInt32(Console.ReadLine());
            int result = value / (int)WeightsCoefficients.Kilogram;
            Console.WriteLine(result);
        }

        static void MainForCoordinates()
        {
            Point point = new Point
            {
                X = 10,
                Y = 15
            };
            point.Print();
            CoordinateQuater result = GetCoordinateQuater(point);
            switch (result)
            {
                case CoordinateQuater.First:
                case CoordinateQuater.Second:
                case CoordinateQuater.Third:
                case CoordinateQuater.Fouth:
                    Console.WriteLine(result);
                    break;
                case CoordinateQuater.Zero:
                    Console.WriteLine("You're on axis");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Phone phone = new Phone("1234567", "Xiaomi", 500);

            phone.SendMessage("Hello world!",
                "4323", "52342", "123122", "1231", "45233");

            //Console.WriteLine(phone);
        }
    }
}
