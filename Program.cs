using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefanini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingredients Carrot = new Ingredients("Carrot", 2);
            Ingredients Potato = new Ingredients("Potato", 2);
            Ingredients Dough = new Ingredients("Dough", 4);
            Ingredients Sauce = new Ingredients("Sauce", 3);
            Ingredients Meat = new Ingredients("Meat", 5);

            Dishes pizza = new Dishes("Pizza", "peperoni", 30) { Components = new List<Ingredients>() { Meat, Dough, Sauce } };
            pizza.Price = PriceCalculator(pizza.Components);
            Dishes burger = new Dishes("Burger", "chiken burger", 20) { Components = new List<Ingredients>() { Meat, Dough, Potato } };
            burger.Price = PriceCalculator(burger.Components);
            Dishes soup = new Dishes("Soup", "veggie soup", 15) { Components = new List<Ingredients>() { Sauce, Carrot, Potato } };
            soup.Price = PriceCalculator(soup.Components);
            Dishes shawarma = new Dishes("Shawrma", "Das kebab", 15) { Components = new List<Ingredients> { Meat, Carrot, Potato } };
            shawarma.Price = PriceCalculator(shawarma.Components);

            List<Dishes> dishes = new List<Dishes>()
            {
                pizza, burger, soup, shawarma
            };

            foreach (var dish in dishes)
            {
                Console.Write($"Dish name: {dish.Name}, Description: {dish.Description}, Price: {dish.Price}, Components:");
                foreach (var comp in dish.Components)
                {
                    Console.Write(" " + comp.Name + ",");
                }
                Console.WriteLine();
            }

            Cook cook1 = new Cook("petru");
            Cook cook2 = new Cook("talon");
            List<Cook> cooks = new List<Cook>()
            {
                cook1, cook2
            };

            while (true)
            {
                string dishName = Console.ReadLine().ToLower();
                if (dishes.Any(x => x.Name.Trim().ToLower() == dishName))
                {
                    if (cooks.Any(x => x.Orders.Count < 5))
                    {
                        Cook assignedCook = cooks.First(x => x.Orders.Count == cooks.Select(y => y.Orders.Count).Min());
                        assignedCook.Orders.Add(dishes.First(x => x.Name.Trim().ToLower() == dishName));
                        Console.WriteLine($"Order accepted, you have to wait: {assignedCook.Orders.Sum(x => x.CookingTime)} minutes");
                    }

                    else
                        Console.WriteLine("No cooks available");

                }

                else
                    Console.WriteLine("There is no such dish in the menu, try again!");
            }

            Console.ReadLine();

        }
        public static float PriceCalculator(List<Ingredients> comp)
        {
            float sum = 0;
            foreach (var ing in comp)
            {
                sum += ing.Price;
            }
            sum += sum * 20 / 100F;
            return sum;
        }

    }
}
