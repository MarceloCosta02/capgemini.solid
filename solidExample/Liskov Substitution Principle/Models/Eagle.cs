using System;
using System.Collections.Generic;
using System.Text;

namespace solidExample.Single_Responsibility_Principle.Models
{
    public class Eagle : Animal
    {
        public Eagle(string name, string type) :
            base(name, type)
        { }

        public override string GetCharacteristic()
        {
            return "Voa";
        }
    }
}
