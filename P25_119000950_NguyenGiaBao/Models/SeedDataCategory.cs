using Microsoft.EntityFrameworkCore;


namespace RazorPagesMovie.Models
{
    public static class SeedDataCategory
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.category == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.category.Any())
                {
                    return;   // DB has been seeded
                }

                context.category.AddRange(
                    new category
                    {
                        Id = "1"
                        Name="GiaBaoOke"
                    },

                    new category
                    {
                        Id = "1"
                        Name="GiaBaoOke"
                    },

                   new category
                    {
                        Id = "1"
                        Name="GiaBaoOke"
                    },

                   new category
                    {
                        Id = "1"
                        Name="GiaBaoOke"
                    },
                );
                context.SaveChanges();
            }
        }
    }
}