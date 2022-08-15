using System.ComponentModel;

namespace AdvancedLeemans.Entities.Base
{
    public abstract class BaseSalesItem : Entity
    {
        [Description("Productnaam")]
        public string? ItemName { get; set; }

        [Description("Prijs")]
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} ; {ItemName} = {Price} EUR";
        }
    }
}