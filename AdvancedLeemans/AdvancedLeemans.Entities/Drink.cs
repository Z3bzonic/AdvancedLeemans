using AdvancedLeemans.Entities.Base;

namespace AdvancedLeemans.Entities
{
    public class Drink : BaseSalesItem
    {
        /// <summary>
        /// Centiliter
        /// </summary>
        public int Cl { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} ; {Cl} cl";
        }
    }
}