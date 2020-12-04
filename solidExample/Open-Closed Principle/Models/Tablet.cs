using System;
using System.Collections.Generic;
using System.Text;

namespace solidExample.Single_Responsibility_Principle.Models
{
    public class Tablet : Device
    {      
        public Tablet(string brand, Decimal price) :
            base(brand, price) { }

        public override void AplicarDesconto()
        {
            Price *= .5M;
        }
    }
}
