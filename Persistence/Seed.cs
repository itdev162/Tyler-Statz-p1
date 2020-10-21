using System.Collections.Generic;
using System.Linq;

using Domain;

namespace Persistence
{
    public class Seed
    {
        
        public static void SeedData(DataContext context)
        {
            if(context.Basketball.Count() == 0)
            {
                List<Basketball> seedPosts = new List<Basketball>
                {
                new Basketball() { Tittle = "Basketball" , Synopsis = "Basketball is a fun sport for anyone to play outside or inside." },
                new Basketball() { Tittle = "Adam Silver" , Synopsis = "He is the guy who owns the NBA" },
                new Basketball() { Tittle = "Sport" , Synopsis = "This is just one of the sports that you can have fun with friends or family." },
                };

                context.Basketball.AddRange(seedPosts);
                context.SaveChanges();
            }
        }
    }
}