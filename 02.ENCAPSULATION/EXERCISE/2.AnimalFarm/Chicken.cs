﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
    public class Chicken
    {
        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            private set
            {
                ThrowIfInvalidName(value);
                this.name = value;
            }
        }
        public int Age
        {
            get 
            {
                return age;
            } 
            set 
            {
                ThrowIfInvalidAge(value);
                this.age = value;
            }
        }
        public double  ProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }

        private void ThrowIfInvalidName(string name)
        {
            if (name == null || name == string.Empty || name == " ")
            {
                throw new ArgumentException("Name cannot be empty.");
            }
        }
        private void ThrowIfInvalidAge(int age)
        {
            if (age <= 0 || age > 15)
            {
                throw new ArgumentException("Age should be between 0 and 15.");
            }
        }
    }
}
