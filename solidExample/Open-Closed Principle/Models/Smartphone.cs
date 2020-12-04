using System;
using System.Collections.Generic;
using System.Text;

namespace solidExample.Single_Responsibility_Principle.Models
{
    public class Smartphone : Device
    {      
        public Smartphone(string brand, Decimal price) :
            base(brand, price) { }

        public override void AplicarDesconto()
        {
            Price *= .9M;
        }
    }
}
