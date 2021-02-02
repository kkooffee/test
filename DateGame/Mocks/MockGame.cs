using DateGame.Interfaces;
using DateGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateGame.Mocks
{
    public class MockGame : IGames
    {
        private IEnumerable<Game> _games;
        public MockGame()
        {
            _games = new List<Game>{
                    new Game { id=1, name = "name1", development = "development_1", genre = "ganr1" },
                    new Game { id=2, name = "name2", development = "development_2", genre = "ganr2" },
                    new Game { id=3, name = "name3", development = "development_3", genre = "ganr3" },
                    new Game { id=4, name = "name4", development = "development_4", genre = "ganr4" },};
        }

        public IEnumerable<Game> AllGame => _games;
        

        public Game CteateGame(Game game)
        {
            _games.Append(game);
            return game;
        }

        public void DeleteGame(int gameId)
        {
            _games.Where(g=>g.id!=gameId);
            //foreach (Game g in _games){ };
        }

        public Game GetGame(int gameId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> SellectGame(string genre)
        {
            throw new NotImplementedException();
        }

        public void UpdateGame(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
