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
        public UserService()
        {
          //  var client = new MongoClient(settings.ConnectionString);
          //  var database = client.GetDatabase(settings.DatabaseName);

            var constr = MongoClientSettings.FromConnectionString("");
            var client = new MongoClient(constr);
            var database = client.GetDatabase("mongotest");
            
            _userdto = database.GetCollection<UserDTO>("usercollections");
        }
        public async Task<List<UserDTO>> GetAllAsync()
        {
            return await _userdto.Find(s => true).ToListAsync();
        }
    }
}
