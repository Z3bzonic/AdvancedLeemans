using AdvancedLeemans.DAL;
using AdvancedLeemans.Entities;
using System.ComponentModel;

namespace AdvancedLeemans
{
    public class PizzaHandler
    {
        private DrinkRepository _drinkRepository = new();
        private PizzaRepository _pizzaRepository = new();
        private WrapRepository _wrapRepository = new();

        private static string GetDescription(Type t, string propertyName)
        {
            var property = t.GetProperty(propertyName);
            var attribute = property.GetCustomAttributes(typeof(DescriptionAttribute), true)[0];
            var description = (DescriptionAttribute)attribute;
            return description.Description;
        }

        public void AddPizza()
        {
            var pizza = _pizzaRepository.Add(
                new Pizza {
                    ItemName = AskString(GetDescription(typeof(Pizza), nameof(Pizza.ItemName))),
                    Price = AskDecimal(GetDescription(typeof(Pizza), nameof(Pizza.Price))),
                    MeatType = AskMeatType(GetDescription(typeof(Pizza), nameof(Pizza.MeatType))),
                    Toppings = AskString(GetDescription(typeof(Pizza), nameof(Pizza.Toppings)))
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

            var allItems = repo.Items.OrderBy(p => p.ItemName);    //order by name
            //var allItems = repo.Items.OrderBy(p => p.Price);    //order by price
            foreach (var item in allItems)
            {
                Console.WriteLine($"   {item}");
            }

            Console.WriteLine($"-----");
        }

        public void AddWrap()
        {
            var wrap = _wrapRepository.Add(
                new Wrap {
                    ItemName = AskString(GetDescription(typeof(Wrap), nameof(Wrap.ItemName))),
                    Price = AskDecimal(GetDescription(typeof(Wrap), nameof(Wrap.Price))),
                    MeatType = AskMeatType(GetDescription(typeof(Wrap), nameof(Wrap.MeatType))),
                    Sauce = AskString(GetDescription(typeof(Wrap), nameof(Wrap.Sauce)))
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

            var allItems = repo.Items.OrderBy(p => p.ItemName);    //order by name
            //var allItems = repo.Items.OrderBy(p => p.Price);    //order by price
            foreach (var item in allItems)
            {
                Console.WriteLine($"   {item}");
            }

            Console.WriteLine($"-----");
        }

        public void AddDrink()
        {
            var wrap = _drinkRepository.Add(
                new Drink
                {
                    ItemName = AskString(GetDescription(typeof(Drink), nameof(Drink.ItemName))),
                    Price = AskDecimal(GetDescription(typeof(Drink), nameof(Drink.Price))),
                    Cl = AskInteger(GetDescription(typeof(Drink), nameof(Drink.Cl)))
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

            var allItems = repo.Items.OrderBy(p => p.ItemName);    //order by name
            //var allItems = repo.Items.OrderBy(p => p.Price);    //order by price
            foreach (var item in allItems)
            {
                Console.WriteLine($"   {item}");
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