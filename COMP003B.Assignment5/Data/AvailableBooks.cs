using COMP003B.Assignment5.Models;

namespace COMP003B.Assignment5.Data
{
    public static class AvailableBooks
    {
        public static List<Library> Library { get; } = new()
        {
            new Library { Id = 1, Name = "A Season In Hell", Price = 19.99m},
            new Library { Id = 2, Name = "Dantes Inferno", Price = 48.99m},
            new Library { Id = 3, Name = "Uzumaki", Price = 30.00m}
        };
    }
}
