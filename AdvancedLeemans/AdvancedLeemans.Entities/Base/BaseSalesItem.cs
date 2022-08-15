namespace AdvancedLeemans.Entities.Base
{
    public abstract class BaseSalesItem : Entity
    {
        public string? ItemName { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} ; {ItemName} = {Price} EUR";
        }
    }
}