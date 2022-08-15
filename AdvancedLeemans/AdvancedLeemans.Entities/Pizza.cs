using System.ComponentModel;

namespace AdvancedLeemans.Entities
{
    public class Pizza : Food
    {
        [Description("Topping")]
        public string? Toppings { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} ; {nameof(Pizza)}='{Toppings}'";
        }
    }
}