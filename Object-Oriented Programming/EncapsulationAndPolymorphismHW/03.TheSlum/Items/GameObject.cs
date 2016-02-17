namespace TheSlum
{
    public abstract class GameObject
    {
        protected GameObject(string id)
        {
            Id = id;
        }

        public string Id { get; private set; }
    }
}
