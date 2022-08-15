﻿using AdvancedLeemans.DAL;
using AdvancedLeemans.Entities;

namespace AdvancedLeemans
{
    public class PizzaHandler
    {
        private DrinkRepository _drinkRepository = new();
        private PizzaRepository _pizzaRepository = new();
        private WrapRepository _wrapRepository = new();

        public void AddPizza()
        {
            var pizza = _pizzaRepository.Add(
                new Pizza {
                    ItemName = AskString(nameof(Pizza.ItemName)),
                    Price = AskDecimal(nameof(Pizza.Price)),
                    MeatType = AskMeatType(nameof(Pizza.MeatType)),
                    Toppings = AskString(nameof(Pizza.Toppings))
                    }
                );

            Console.WriteLine($"New {nameof(Pizza)} => {pizza}");
        }

        public void ListPizzas()
        {
            var entityType = nameof(Pizza);
            var repo = _pizzaRepository;
            var count = repo.GetAll().Count;
            Console.WriteLine($"{count} {entityType}{(count == 1 ? "" : "s")}:");

            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine($"   {repo.Items[i]}");
            //}

            var allPizzas = repo.Items.OrderBy(p => p.ItemName);    //order by pizza name
            //var allPizzas = repo.Items.OrderBy(p => p.Price);    //order by pizza price
            foreach (var pizza in allPizzas)
            {
                Console.WriteLine($"   {pizza}");
            }

            Console.WriteLine($"-----");
        }

        public void AddWrap()
        {
            var wrap = _wrapRepository.Add(
                new Wrap {
                    ItemName = AskString(nameof(Wrap.ItemName)),
                    Price = AskDecimal(nameof(Wrap.Price)),
                    MeatType = AskMeatType(nameof(Wrap.MeatType)),
                    Sauce = AskString(nameof(Wrap.Sauce))
                    }
                );

            Console.WriteLine($"New {nameof(Wrap)} => {wrap}");
        }

        public void ListWraps()
        {
            var entityType = nameof(Wrap);
            var repo = _wrapRepository;
            var count = repo.GetAll().Count;
            Console.WriteLine($"{count} {entityType}{(count == 1 ? "" : "s")}:");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"   {repo.Items[i]}");
            }
            Console.WriteLine($"-----");
        }

        public void AddDrink()
        {
            var wrap = _drinkRepository.Add(
                new Drink
                {
                    ItemName = AskString(nameof(Drink.ItemName)),
                    Price = AskDecimal(nameof(Drink.Price)),
                    Cl = AskInteger(nameof(Drink.Cl))
                }
                );

            Console.WriteLine($"New {nameof(Drink)} => {wrap}");
        }

        public void ListDrinks()
        {
            var entityType = nameof(Drink);
            var repo = _drinkRepository;
            var count = repo.GetAll().Count;
            Console.WriteLine($"{count} {entityType}{(count == 1 ? "" : "s")}:");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"   {repo.Items[i]}");
            }
            Console.WriteLine($"-----");
        }

        #region Helper Methods
        private static string? AskString(string objectName)
        {
            Console.WriteLine($"Enter {objectName}:");
            var input = Console.ReadLine();
            return input;
        }

        private static decimal AskDecimal(string objectName)
        {
            Console.WriteLine($"Enter {objectName}:");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException(nameof(objectName));

            return decimal.Parse(input);
        }

        private static int AskInteger(string objectName)
        {
            Console.WriteLine($"Enter {objectName}:");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException(nameof(objectName));

            return int.Parse(input);
        }

        private static MeatType AskMeatType(string objectName)
        {
            Console.WriteLine($"Enter {objectName}:");
            Console.WriteLine($"{(int)MeatType.Meat} = {MeatType.Meat}");
            Console.WriteLine($"{(int)MeatType.Chicken} = {MeatType.Chicken}");

            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException(nameof(objectName));

            return Enum.Parse<MeatType>(input);
        }
        #endregion Helper Methods
    }
}