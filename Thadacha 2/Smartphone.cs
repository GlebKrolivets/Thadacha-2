using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Thadacha_2
{
    internal class Smartphone
    {
        private string brand;
        private string model;
        private int year;
        private int memory;
        private string color;
        private int battery;

        public Smartphone(string brand, string model, int year, int memory, string color, int battery)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.memory = memory;
            this.color = color;
            this.battery = battery;
        }
        public void Info()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Yaer: {year}");
            Console.WriteLine($"Memory(Gb): {memory}");
            Console.WriteLine($"Colore: {color}");
            Console.WriteLine($"Status battery: {battery}%");
        }
        public void UpdateBattery(int battery)
        {
            this.battery = battery;
            Console.WriteLine("Battery was updated");
        }
        public bool NeedsToReplaced()
        {
            return battery < 60;
        }
        public void Reset()
        {
            battery = 0;
            Console.WriteLine("Battery was replaced");
        }
    }
}
