using System.ComponentModel;

namespace AdvancedLeemans.Entities
{
    public class Wrap : Food
    {
        [Description("Saus")]
        public string? Sauce { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} ; {nameof(Wrap)}='{Sauce}'";
        }
    }
}