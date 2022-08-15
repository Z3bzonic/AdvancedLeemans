using AdvancedLeemans.Entities.Base;

namespace AdvancedLeemans.DAL.Base
{
    public abstract class BaseRepository<T> where T : Entity
    {
        public readonly List<T> Items = new();

        public List<T> GetAll()
        {
            return Items;
        }

        public T Add(T instance)
        {
            Items.Add(instance);
            instance.Id = Items.Count;

            return instance;
        }

        //public void Delete(T instance)
        //{
        //    Items.Remove(instance);
        //}
    }
}