using SQLite;
using card_reader.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace card_reader.Database
{
    public class CardDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public CardDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Card>().Wait();
        }

        public Task<List<Card>> GetCards()
        {
            return _database.Table<Card>().ToListAsync();
        }

        public Task<Card> GetCard(int id)
        {
            return _database.Table<Card>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> CreateCard(Card card)
        {
            _database.InsertAsync(card);
            return _database.ExecuteScalarAsync<int>(@"select MAX(id) from 'Card'"); // vrati posledni ID
        }

        public Task<int> EditCard(Card card)
        {
            return _database.UpdateAsync(card);
        }


        public Task<int> DeleteCard(Card card)
        {
            return _database.DeleteAsync(card);
        }
    }
}