namespace Notes.Identity.Data
{
    public class DbInitilizer
    {
        public static void Initialize(AuthDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
