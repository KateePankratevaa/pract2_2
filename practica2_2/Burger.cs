using Microsoft.VisualBasic.FileIO;
using practica2_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2_2
{
    public class Burger : Product
    {
        public List<Option> options { get; set; }

        public override decimal Price
        {
            
            get
            {
                decimal total = this.Base_Price;
                foreach (var option in options)
                {
                    total += option.Price;
                }
                return total;
            }
            set
            {
                this.Base_Price = value;
            }
        }

        public void AddOption(Option option)
        {
            options.Add(option);
        }

        public void ClearOptions()
        {
            options.Clear();
        }
    }
}


