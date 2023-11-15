using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2_2 {
    public class Drink : Product
    {
        public double Volume { get; set; }
        public bool IsBottled { get; set; }

        public override decimal Price
        {
            get
            {
                if (IsBottled)
                {
                    return this.Base_Price + 25;
                }
                else
                    return this.Base_Price;
            }
            set
            {
                this.Base_Price = value;
            }
        }
    }
}
