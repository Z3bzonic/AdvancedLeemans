using AdvancedLeemans.Entities.Base;
using System.ComponentModel;

namespace AdvancedLeemans.Entities
{
    public class Drink : BaseSalesItem
    {
        /// <summary>
        /// Centiliter
        /// </summary>
        [Description("centiliter")]
        public int Cl { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} ; {Cl} cl";
        }
    }
}