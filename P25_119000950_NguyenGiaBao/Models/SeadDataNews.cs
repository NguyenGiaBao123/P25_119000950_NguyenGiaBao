using Microsoft.EntityFrameworkCore;


namespace RazorPagesMovie.Models
{
    public static class SeedDataNews
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.news == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.news.Any())
                {
                    return;   // DB has been seeded
                }

                context.news.AddRange(
                    new news
                    {
                        Id ="asd",
                        Title = "qwe",
                        ImageUrl = "zxc",
                        Content = "thachdau",
                        Author = "caothu",
                        CreatedAt= "dct"
                    },

                    new news
                    {
                       Id ="asd",
                        Title = "qwe",
                        ImageUrl = "zxc",
                        Content = "thachdau",
                        Author = "caothu",
                        CreatedAt= "dct"
                    },

                   new news
                    {
                        Id ="asd",
                        Title = "qwe",
                        ImageUrl = "zxc",
                        Content = "thachdau",
                        Author = "caothu",
                        CreatedAt= "dct"
                    },

                   new news
                    {
                        Id ="asd",
                        Title = "qwe",
                        ImageUrl = "zxc",
                        Content = "thachdau",
                        Author = "caothu",
                        CreatedAt= "dct"
                    },
                );
                context.SaveChanges();
            }
        }
    }
}