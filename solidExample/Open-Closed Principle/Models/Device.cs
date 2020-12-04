using System;
using System.Collections.Generic;
using System.Text;

namespace solidExample.Single_Responsibility_Principle.Models
{
    public class Device
    {
        public string Brand { get; set; }
        public Decimal Price { get; set; }

        private const decimal STANDARD_DISCOUNT = .3M;

        public Device(string brand, Decimal price)
        {
            this.Brand = brand ?? throw new ArgumentNullException();
            this.Price = price;
        }

        public virtual void AplicarDesconto()
        {
            this.Price = this.Price * STANDARD_DISCOUNT;
        }

        //public void AplicarDesconto()
        //{
        //    if (this.Brand == "Smarthphone")
        //        this.Price = this.Price * .9m;
        //    if (this.Brand == "Tablet")
        //        this.Price = this.Price * .5m;
        //}
    }
}
