using System;
using DesignPatterns.Models;

namespace DesignPatterns.ModelBuilders
{
    public class CarModelBuilder
    {
        private string color = "red";
        private string brand = "Ford";
        private string model = "Mustang";
        private int year = DateTime.Now.Year;
        
        public CarModelBuilder setColor(String color)
        {
            this.color = color;
            return this;
        }

        public CarModelBuilder setBrand(String brand)
        {
            this.brand = brand;
            return this;
        }

        public CarModelBuilder setModel(String model)
        {
            this.model = model;
            return this;
        }

        public Vehicle Build()
        {
            return new Car(color, brand, model, year);
        }
    }
}
