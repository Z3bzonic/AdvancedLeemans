namespace AdvancedLeemans.Entities
{
    public class Wrap : Food
    {
        public string? Sauce { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} ; Wrap='{Sauce}'";
        }
    }
}