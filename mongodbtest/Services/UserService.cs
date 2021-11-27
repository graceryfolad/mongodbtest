using MongoDB.Driver;
using mongodbtest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mongodbtest.Services
{
    public class UserService
    {
        private readonly IMongoCollection<UserDTO> _userdto;
        public UserService(DatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _userdto = database.GetCollection<UserDTO>(settings.UserCollectionName);
        }
        public async Task<List<UserDTO>> GetAllAsync()
        {
            return await _userdto.Find(s => true).ToListAsync();
        }
    }
}
