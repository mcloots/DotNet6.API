namespace DotNet.API.Models
{
    public class DBInitializer
    {
        public static void Initialize(ToDoContext context)
        {
            context.Database.EnsureCreated();

            // Look for any lists.
            if (context.Lists.Any())
            {
                return;   // DB has been seeded
            }

            context.Lists.AddRange(
                new List { Name = "Home" },
                new List { Name = "School" }
                );

            context.Items.AddRange(
               new Item { Description = "Cooking", List = context.Lists.First() },
               new Item { Description = "Cleaning", List = context.Lists.First() }
               );
            context.SaveChanges();
        }

    }
}
