using Microsoft.EntityFrameworkCore;


namespace RazorPagesMovie.Models
{
    public static class SeedDataComment
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.comment == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.comment.Any())
                {
                    return;   // DB has been seeded
                }

                context.comment.AddRange(
                    new comment
                    {
                        Id = "abc",
                        Content = "dongvat",
                        Author = "connguoi",
                        CreatedAt= "ct"
                    },

                     new comment
                    {
                        Id = "abc",
                        Content = "dongvat",
                        Author = "connguoi",
                        CreatedAt= "ct"
                    },

                    new comment
                    {
                        Id = "abc",
                        Content = "dongvat",
                        Author = "connguoi",
                        CreatedAt= "ct"
                    },

                    new comment
                    {
                        Id = "abc",
                        Content = "dongvat",
                        Author = "connguoi",
                        CreatedAt= "ct"
                    },
                );
                context.SaveChanges();
            }
        }
    }
}