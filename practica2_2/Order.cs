using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2_2 {
    public class Order 
    {

        private int id = 1;
        protected List<Product> products { get; set; }
        public int Number;
        public DateTime OrderTime = DateTime.Now;


        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ClearProduct()
        {
            products.Clear();
        }

        public decimal TotalPrice()
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.Price;
            }
            return total;
        }

        public string GetCheck()
        {
            string check = $"Номер заказа: {Number}\nДата и время:{OrderTime.Day} {OrderTime.Hour}:{OrderTime.Minute}\n";
            foreach (var product in products)
            {
                check = check + $"Продукт:{product.Name} Цена:{product.Price}\n";
            }
            Number = id++;
            return check;
        }
    }
}
