using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer
       : System.Data.Entity.DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Artist { Name = "Al Di Meola" });
            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Genres.Add(new Genre { Name = "Pop" });
            context.Albums.Add(new Album
            {
                Selecciona=true,
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Price = 9.99m,
                Title = "Caravan"
            });
            context.Albums.Add(new Album
            {
                Selecciona=true,
                Artist = new Artist { Name = "Metallica" },
                Genre = new Genre { Name = "Rock" },
                Price = 9.99m,
                Title = "Death Magnetic"
            });
            base.Seed(context);
        }
    }
}