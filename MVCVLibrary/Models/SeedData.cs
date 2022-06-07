using Microsoft.EntityFrameworkCore;
using MVCVLibrary.Data;

namespace MVCVLibrary.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryContext(serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                if (context.Book.Any())
                {
                    return; // If there's books in the db, then just return
                }
                context.Book.AddRange(
                    new Book { Title = "Tiny C# Projects", CallNumber = "AXD 2029" },
                    new Book { Title = "Guns of August", CallNumber = "AOI 2038" }
                );
                context.SaveChanges();
            }
        }
    }
}
