using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {

            Seller sel1 = new Seller();
            sel1.Name = "Juan Carlos";
            sel1.Age = 45;

            Seller sel2 = new Seller();
            sel2.Name = "Maria Gomez";
            sel2.Age = 36;

            Seller sel3 = new Seller();
            sel3.Name = "Juanita";
            sel3.Age = 27;

            Product prod1 = new Product();
            prod1.Name = "Coffee";
            prod1.Price = 4000;

            Product prod2 = new Product();
            prod2.Name = "Shirt";
            prod2.Price = 20000;

            Product prod3 = new Product();
            prod3.Name = "UTP Cable";
            prod3.Price = 8000;
           
            Sale sale1 = new Sale();
            sale1.Product = prod2;
            sale1.Seller = sel1;
            sale1.Comments = "Men's t-shirt";

            Sale sale2 = new Sale();
            sale2.Product = prod3;
            sale2.Seller = sel2;
            sale2.Comments = "2 meters";

            Sale sale3 = new Sale();
            sale3.Product = prod1;
            sale3.Seller = sel3;
            sale3.Comments = "Coffee from Colombia";

            //Calculate sales total amount
            int salesTotal1 = 0;
            int salesTotal2 = 0;
            int salesTotal3 = 0;
            if (sale1.Product.Price != 0)
            {
                salesTotal1 = sale1.Product.Price;
            }
            if (sale2.Product.Price != 0)
            {
                salesTotal2 = sale2.Product.Price + salesTotal1;
            }
            if (sale3.Product.Price != 0)
            {
               salesTotal3 = sale3.Product.Price + salesTotal2;
            }

            Console.WriteLine("Total sales = "+ salesTotal3);




        }
    }
}
