using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateGame.Models
{
    public class DbInitial
    {
        static public void Initial(DbContent content)
        {
           
            if (!content.games.Any())
            {
                content.games.AddRange(Games().Select(c => c.Value));
                content.SaveChanges();
            }
        }
        private static Dictionary<string, Game> DiGame;
        public static Dictionary<string,Game> Games()
        {
            if (DiGame==null)
            {
                var list = new Game[]
                {
                    new Game { name = "name1", development = "development_1", genre = "ganr1" },
                    new Game { name = "name2", development = "development_2", genre = "ganr2" },
                    new Game { name = "name3", development = "development_3", genre = "ganr3" },
                    new Game { name = "name4", development = "development_4", genre = "ganr4" },
                };
                DiGame = new Dictionary<string, Game>();
                foreach (Game el in list)
                    DiGame.Add(el.name, el);
            }
            return DiGame;
        }
    }
}
