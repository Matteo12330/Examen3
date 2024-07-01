using SQLite;
using ExamenProgra.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ExamenProgra.Data
{
    public class DatabaseServiceMR
    {
        private readonly SQLiteAsyncConnection _database;
        public DatabaseServiceMR(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<JokeMR>().Wait();
        }
        public Task<List<JokeMR>> GetJokesAsync()
        {
            return _database.Table<JokeMR>().ToListAsync();
        }
        public Task<int> SaveJokeAsync(JokeMR joke)
        {
            return _database.InsertAsync(joke);
        }
        public Task<int> DeleteJokeAsync(JokeMR joke)
        {
            return _database.DeleteAsync(joke);
        }
    }
}