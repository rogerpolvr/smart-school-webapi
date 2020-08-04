namespace SmartSchool.WebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext context;

        public Repository(DataContext context)
        {

            this.context = context;
        }
        public void Add<T>(T Entity) where T : class
        {
            this.context.Add(Entity);
        }

        public void Update<T>(T Entity) where T : class
        {
            this.context.Update(Entity);
        }

        public void Remove<T>(T Entity) where T : class
        {
            this.context.Remove(Entity);
        }

        public bool SaveChanges() =>
         (this.context.SaveChanges() > 0);
    }
}