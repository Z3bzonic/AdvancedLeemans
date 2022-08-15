using System.Diagnostics;

namespace AdvancedLeemans.Entities.Base
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)} = {Id}";
        }
    }
}