using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHW9
{
    public class Phone
    {
        private string _number;
        private string _model;
        private double _weight;

        public Phone(string number, string model, double weight)
            : this(number, model)
        {
            _weight = weight;
        }

        public Phone(string number, string model)
        {
            _number = number;
            _model = model;
        }

        public Phone() : this(string.Empty, string.Empty, 150)
        {

        }

        public void ReceiveCall(string callerName)
        {
            Console.WriteLine($"Calling {callerName}");
        }

        public void ReceiveCall(string callerName, string callerNumber)
        {
            Console.WriteLine($"Calling {callerName}\t{callerNumber}");
        }

        public void SendMessage(string info,
            params string[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(
                    $"Mesage with {info} sent to {number}");
            }
        }

        public string GetNumber()
        {
            return _number;
        }

        public override string ToString()
        {
            return $"Number:{_number}{Environment.NewLine}" +
                $"Model:{_model}{Environment.NewLine}" +
                $"Weight:{_weight}";
        }
    }
}
