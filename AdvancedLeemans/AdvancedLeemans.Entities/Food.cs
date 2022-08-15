using AdvancedLeemans.Entities.Base;

namespace AdvancedLeemans.Entities
{
    public class Food : BaseSalesItem
    {
        public MeatType MeatType { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} ; {nameof(MeatType)}={MeatType}";
        }
    }
}