using System;
using System.Collections.Generic;
using System.Text;

namespace solidExample.Single_Responsibility_Principle.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public abstract string GetCharacteristic();

        public Animal(string name, string type)
        {
            this.Name = name ?? throw new ArgumentNullException();
            this.Type = type;
        }       
    }
}
