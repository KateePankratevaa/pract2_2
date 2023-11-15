using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2_2 {
    public abstract class Product {
        public string Name { get; set; }
        public decimal Base_Price { get; set; }
        public string Image { get; set; }

        public abstract decimal Price
        {
            get; set;
        }
    }
}
