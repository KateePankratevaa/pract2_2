using practica2_2;

Burger cheeseburger = new Burger();
cheeseburger.Name = "Чизбургер";
cheeseburger.Price = 100;
cheeseburger.Image = "cheeseburger.png";
Option becon = new Option("Бекон", 25);
cheeseburger.AddOption(becon);

Drink sprite = new Drink();
sprite.Name = "Sprite";
sprite.Price = 150;
sprite.Image = "sprite.png";
sprite.Volume = 330;
sprite.IsBottled = true;


Burger chickenburger = new Burger();
chickenburger.Name = "ЧикенБургер";
chickenburger.Price = 100;
chickenburger.Image = "chickenburger.png";
Option cheese = new Option("Сыр", 35);
chickenburger.AddOption(cheese);

Drink dobryi = new Drink();
dobryi.Name = "Добрый";
dobryi.Price = 70;
dobryi.Image = "dobryi.png";
dobryi.Volume = 500;

Order order = new Order();
order.AddProduct(cheeseburger);
order.AddProduct(chickenburger);
order.AddProduct(sprite);
order.AddProduct(dobryi);

Console.WriteLine(order.GetCheck());