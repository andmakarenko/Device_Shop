using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device_Shop
{
    internal class Laptop : Device
    {
        const double MIN_LAPTOP_DIAGONAL = 10;
        public double Diagonal
        {
            get
            {
                return diagonal;
            }
            set
            {
                if (value < MIN_LAPTOP_DIAGONAL)
                {
                    throw new ArgumentException("Cant assign a value less than minimal laptop diagonal.");
                }
                diagonal = value;
            }
        }
        double diagonal;

        public double CPUHz
        {
            get
            {
                return cpuHz;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cant assign a negative value to CPU frequency.");
                }
                cpuHz = value;
            }
        }
        double cpuHz;

        public uint RAM
        {
            get
            {
                return ram;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cant assign a negative value to RAM amount.");
                }
                ram = value;
            }
        }
        uint ram;

        public Laptop():
            this("LaptopProd", "LaptopModel", 0, 0.0, new Colors(Color.None))
        { }
        public Laptop(string producer, string model, uint stock, double price, Colors colors):
            this(producer, model, stock, price, colors, MIN_LAPTOP_DIAGONAL, 3.2, 8)
        { }

        public Laptop(string producer, string model, uint stock, double price, Colors colors, double diagonal, double cpuHz, uint ram):
            base(producer, model, stock, price, colors)
        {
            Diagonal = diagonal;
            CPUHz = cpuHz;
            RAM = ram;
        }

        public override string ToString()
        {
            string output = "";
            output += "Laptop Info:\n";
            output += $"{Producer} {Model} | {Colors.ToString()}\n";
            output += $"Technical characteristics: Diagonal(cm): {Diagonal} | CPU frequency(GHz): {CPUHz} | RAM(GB): {RAM}\n";
            output += $"Models in storage: {Storage}\n";
            output += $"Price: {Price}\n";
            return output;
        }
        
    }
}
