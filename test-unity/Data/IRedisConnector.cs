using System;
using StackExchange.Redis;

namespace testunity.Data
{
    public interface IRedisConnector
    {
        IDatabase GetDatabase(int databaseNumber = 0);
    }
}
