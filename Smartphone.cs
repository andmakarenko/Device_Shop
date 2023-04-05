using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Device_Shop
{
    internal class Smartphone : Device
    {
        const double MIN_PHONE_DIAGONAL = 4;
        public SmartphoneOS OS
        {
            get
            {
                return os;
            }
            set
            {
                if (!Enum.IsDefined(typeof(SmartphoneOS), value))
                {
                    throw new ArgumentException("Invalid value assignment to smartphone OS.");
                }
                os = value;
            }
        }
        SmartphoneOS os;

        public double Diagonal
        {
            get
            {
                return diagonal;
            }
            set
            {
                if (value < MIN_PHONE_DIAGONAL)
                {
                    throw new ArgumentException("Cant assign a value less than minimal phone diagonal.");
                }
                diagonal = value;
            }
        }
        double diagonal;

        public Smartphone() :
            this("LaptopProd", "LaptopModel", 0, 0.0, new Colors(Color.None))
        { }
        public Smartphone(string producer, string model, uint stock, double price, Colors colors) :
            this(producer, model, stock, price, colors, SmartphoneOS.None, MIN_PHONE_DIAGONAL)
        { }

        public Smartphone(string producer, string model, uint stock, double price, Colors colors, SmartphoneOS os, double diagonal) :
           base(producer, model, stock, price, colors)
        {
            OS = os;
            Diagonal = diagonal;
        }

        public override string ToString()
        {
            string output = "";
            output += "Smartphone Info:\n";
            output += $"{Producer} {Model} | {Colors.ToString()}\n";
            output += $"Technical characteristics: Diagonal(cm): {Diagonal} | Operational System: {OS.ToString()}\n";
            output += $"Models in storage: {Storage}\n";
            output += $"Price: {Price}\n";
            return output;
        }
    }
}
