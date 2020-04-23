using StackExchange.Redis;
using System;

namespace RedisConsoleApp
{
    class Program
    {
        static void  Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
          IDatabase db=  redis.GetDatabase();
           //string
            db.StringSet("time", DateTime.Now.ToShortTimeString());
            db.StringSet("city", "ankara");
           // db.KeyDelete("city");
            Console.WriteLine(db.StringGet("time")+"\n"+db.StringGet("city"));
         
            Console.ReadKey();
        }
    }
}
