namespace AdvancedLeemans.Entities
{
    public class Pizza : Food
    {
        public string? Toppings { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} ; Pizza='{Toppings}'";
        }
    }
}