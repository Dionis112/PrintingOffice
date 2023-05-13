namespace Roamin.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(RoamingDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
