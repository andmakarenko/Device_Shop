using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Device_Shop
{
    internal class Tablet : Device
    {
        const double MIN_TABLET_DIAGONAL = 8;

        public ScreenType ScreenType
        {
            get
            {
                return screenType;
            }
            set
            {
                if (!Enum.IsDefined(typeof(ScreenType), value))
                {
                    throw new ArgumentException("Invalid value assignment to tablet screen type.");
                }
                screenType = value;
            }
        }
        ScreenType screenType;

        public double Diagonal
        {
            get
            {
                return diagonal;
            }
            set
            {
                if (value < MIN_TABLET_DIAGONAL)
                {
                    throw new ArgumentException("Cant assign a value less than minimal phone diagonal.");
                }
                diagonal = value;
            }
        }
        double diagonal;

        public Tablet() :
            this("LaptopProd", "LaptopModel", 0, 0.0, new Colors(Color.None))
        { }
        public Tablet(string producer, string model, uint stock, double price, Colors colors) :
            this(producer, model, stock, price, colors, ScreenType.None, MIN_TABLET_DIAGONAL)
        { }

        public Tablet(string producer, string model, uint stock, double price, Colors colors, ScreenType screenType, double diagonal) :
           base(producer, model, stock, price, colors)
        {
            ScreenType = screenType;
            Diagonal = diagonal;
        }

        public override string ToString()
        {
            string output = "";
            output += "Tablet Info:\n";
            output += $"{Producer} {Model} | {Colors.ToString()}\n";
            output += $"Technical characteristics: Diagonal(cm): {Diagonal} | Screen: {ScreenType.ToString()}\n";
            output += $"Models in storage: {Storage}\n";
            output += $"Price: {Price}\n";
            return output;
        }
    }
}
