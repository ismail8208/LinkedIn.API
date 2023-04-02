
using DataAccess;

namespace OnlineCommunity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseCreated();
        }
        private static void DatabaseCreated()
        {
            using (var context = new OnlineCommunityContext())
            {
                context.Database.EnsureCreated();
            }
        }

    }
}
