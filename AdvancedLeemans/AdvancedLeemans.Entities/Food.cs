using AdvancedLeemans.Entities.Base;
using System.ComponentModel;

namespace AdvancedLeemans.Entities
{
    public class Food : BaseSalesItem
    {
        [Description("Vlees type")]
        public MeatType MeatType { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} ; {nameof(MeatType)}={MeatType}";
        }
    }
}