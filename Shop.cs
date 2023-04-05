using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device_Shop
{
    //класс Shop, хранящий список девайсов и методы работы с этим списком
    internal class Shop
    {
        public List<Device> Devices
        {
            get
            {
                return devices;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot assign null to devices.");
                }
                devices = value;
            }
        }
        List<Device> devices;

        public Shop():
            this(new List<Device>())
        { }

        public Shop(List<Device> devices)
        {
            this.Devices = devices;
        }

        //поиск по производителю
        private void SearchByProducer(string producer)
        {
            bool deviceFound = false;
            for (int i = 0; i < devices.Count; i++)
            {
                if (producer.Equals(devices[i].Producer))
                {
                    Console.WriteLine(devices[i].ToString());
                    deviceFound = true;
                }
            }

            if (!deviceFound)
            {
                Console.WriteLine($"No devices produced by {producer} could be found.");
            }
        }

        //поиск по модели
        private void SearchByModel(string model)
        {
            bool deviceFound = false;
            for (int i = 0; i < devices.Count; i++)
            {
                if (model.Equals(devices[i].Model))
                {
                    Console.WriteLine(devices[i].ToString());
                    deviceFound = true;
                }
            }

            if (!deviceFound)
            {
                Console.WriteLine($"No devices with '{model}' model name could be found.");
            }

        }

        //удаление по производителю
        private void DeleteByProducer(string producer)
        {
            bool deviceFound = false;
            for (int i = 0; i < devices.Count; i++)
            {
                if (producer.Equals(devices[i].Producer))
                {
                    devices.Remove(devices[i]);
                    deviceFound = true;
                    i--;
                }
            }

            if (!deviceFound)
            {
                Console.WriteLine($"No devices produced by {producer} could be found.");
            }
        }

        //удаление по модели
        private void DeleteByModel(string model)
        {
            bool deviceFound = false;
            for (int i = 0; i < devices.Count; i++)
            {
                if (model.Equals(devices[i].Model))
                {
                    devices.Remove(devices[i]);
                    deviceFound = true;
                    i--;
                }
            }

            if (!deviceFound)
            {
                Console.WriteLine($"No devices with '{model}' model name could be found.");
            }
        }

        //удаление по критерию
        public void DeleteByParameter()
        {
            int choice;
            Console.WriteLine("By which parameter would you like to delete a device?\n1. Producer\n2. Model\n3. Cancel");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter Producer name:");
                    DeleteByProducer(Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("Enter Model name:");
                    DeleteByModel(Console.ReadLine());
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        //поиск по критерию
        public void SearchByParameter()
        {
            int choice;
            Console.WriteLine("By which parameter would you like to search a device?\n1. Producer\n2. Model\n3. Cancel");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Producer name:");
                    SearchByProducer(Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("Enter Model name:");
                    SearchByModel(Console.ReadLine());
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        //добавление устройства
        public void AddDevice(Device device)
        {
            if (device == null)
            {
                throw new ArgumentNullException("Cant add a null value to device list.");
            }
            devices.Add(device);
        }

        //перегрузка ToString 
        public override string ToString()
        {
            return string.Join("\n", devices) + "------------------------------";
        }

        //индексатор
        public Device this[int index]
        {
            get
            {
                return Devices[index];
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cant add a null value to device list.");
                }
                Devices[index] = value;
            }
        }
    }
}
