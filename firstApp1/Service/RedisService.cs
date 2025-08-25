using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace firstApp1.Service
{
    public class RedisService
    {
        private readonly ConnectionMultiplexer _redis = ConnectionMultiplexer.Connect("localhost:6379");

        public  async Task Set(string key, string value)
        {
            try
            {
                var db = _redis.GetDatabase();

                await db.StringSetAsync(key, value);

                await _redis.CloseAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<string> Get(string key)
        {
            var db = _redis.GetDatabase();
            var value = await db.StringGetAsync(key);
            await _redis.CloseAsync();
            return value;
        }
    }
}
