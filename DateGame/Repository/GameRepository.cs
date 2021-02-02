using DateGame.Interfaces;
using DateGame.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateGame.Repository
{
    public class GameRepository : IGames
    {
        private readonly DbContent dbContent;
        //public string gameSearch=null;

        public GameRepository(DbContent db)
        {
            this.dbContent = db;
        }

        public IEnumerable<Game> AllGame => dbContent.games;

        public Game CteateGame(Game game)
        {
            dbContent.Add(game);
            dbContent.SaveChanges();
            return game;
        }

        public void DeleteGame(int gameId)
        {
            dbContent.Remove(GetGame(gameId));
            dbContent.SaveChanges();
        }

        public Game GetGame(int gameId)
        {
            return dbContent.games.Find(gameId);
        }

        public IEnumerable<Game> SellectGame(string genre) => dbContent.games.Where(g => g.genre == genre);
        //{
        //    throw new NotImplementedException();
        //}

        public void UpdateGame(Game g)
        {
            dbContent.Entry(g).State=EntityState.Modified;
            dbContent.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
