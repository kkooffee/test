using DateGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateGame.ViewModels
{
    public class ViewModelGames
    {
        public IEnumerable<Game> listGames;
        public string GenreSearch { get; set; }

        public ViewModelGames(IEnumerable<Game> listGames)
        {
            this.listGames = listGames;
            //this.GenreSearch = genreSearch;
        }
    }
}
