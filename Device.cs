using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device_Shop
{
    abstract class Device
    {
        public string Producer
        {
            get
            {
                return producer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot assign null or empty string to producer.");
                }
                producer = value;
            }

        }
        string producer;
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot assign null or empty string to model.");
                }
                model = value;
            }

        }
        string model;
        public uint Storage
        { get; }
        public double Price
        { 
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot assign a negative value to price.");
                }
                price = value;
            }
        }
        double price;
        public Colors Colors 
        { 
            get
            {
                return colors;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot assign null to colors.");
                }
                colors = value;
            }
            
        }
        Colors colors;

        public Device() :
            this("DefaultProducer", "DefaultModel", 0, 0.0, new Colors(Color.None))
        { }

        public Device(string producer, string model, uint storage, double price, Colors colors)
        {
            this.Producer = producer;
            this.Model = model;
            this.Storage = storage;
            this.Price = price;
            this.Colors = colors;
        }

        public abstract override string ToString();
    }
}
