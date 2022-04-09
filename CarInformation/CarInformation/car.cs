using System;
using System.Collections.Generic;
using System.Text;

namespace CarInformation
{
    class car
    {
        //Brand,Model,Color,MaxSpeed
        public string Brand;
        public string Model;
        public string Color;
        public int MaxSpeed;
        public car(string brand,string model)
        {
            Brand = brand;
            Model = model;

        }

        internal void Info()
        {
            throw new NotImplementedException();
        }

        public car(int maxspeed,string brand,string model,string color):this(brand,model)
        {
            MaxSpeed = maxspeed;
            Color = color;

        }
        public car()
        {
            Console.WriteLine("Created car");
        }
        

    }
}
