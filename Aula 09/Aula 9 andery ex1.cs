using System;
class ex1O
{
    public struct Product
    {
        public string name;
        public int code;
        public float price;
        public int amount;
    }
    static void Main()
    {
        float all_prices = 0;
        float new_prices = 0;
        Product[] stock = new Product[3];
        for (int p = 0; p < 3; p++)
        {
            Console.Write("\nWrite the name of the product: ");
            string name = Console.ReadLine();
            Console.Write("Write the code: ");
            int code = int.Parse(Console.ReadLine());
            Console.Write("Write the price: ");
            float price = float.Parse(Console.ReadLine());
            Console.Write("Write the amount: ");
            int amount = int.Parse(Console.ReadLine());

            stock[p] = new Product { name = name, code = code, price = price, amount = amount};
        }


        foreach (Product product in stock) 
        {
            new_prices = product.amount * product.price;
            all_prices += new_prices;
        }

        Console.WriteLine($"There's {all_prices} reais in your stock");
    }
}