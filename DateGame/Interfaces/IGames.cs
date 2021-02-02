using DateGame.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateGame.Interfaces
{
    public interface IGames
    {
        IEnumerable<Game> AllGame { get; }
        IEnumerable<Game> SellectGame(string genre);
        Game CteateGame(Game game);
        void UpdateGame(Game game);
        Game GetGame(int gameId);
        void DeleteGame(int gameId);

    }
}
