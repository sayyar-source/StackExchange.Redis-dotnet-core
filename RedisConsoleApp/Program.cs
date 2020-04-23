using StackExchange.Redis;
using System;

namespace RedisConsoleApp
{
    class Program
    {
        static void  Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            //  ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
            //IDatabase db=  redis.GetDatabase();
            // //string
            //  db.StringSet("time", DateTime.Now.ToShortTimeString());
            //  db.StringSet("city", "ankara");
            // // db.KeyDelete("city");
            //  Console.WriteLine(db.StringGet("time")+"\n"+db.StringGet("city"));

            //  Console.ReadKey();
            Console.WriteLine("Hello World!");
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
            IDatabase db = redis.GetDatabase();
            var hashkey = "user";
            HashEntry[] userHashEntry =
                {
                new HashEntry("username","ali"),
                new HashEntry("fullname","ali aydogan"),
                new HashEntry("mobile","095545367"),
                new HashEntry("address","ankara")
                };
            db.HashSet(hashkey, userHashEntry);
            //get value
            if (db.HashExists(hashkey, "username"))
            {
                var user = db.HashGet(hashkey, "username");
                Console.WriteLine("username is: " + user);

            }
            var allHash = db.HashGetAll(hashkey);
            //get all the items
            foreach (var item in allHash)
            {
                //Console.WriteLine(item.Name+" "+ item.Value);
                Console.WriteLine(string.Format("key : {0}, value : {1}", item.Name, item.Value));
                // Result:
                //key: name, value: hassan
                //key : age, value: 26
                //key: city, value: bonab
                //key : username, value: ali
                //key : fullname, value: ali aydogan
                //key: mobile, value: 095545367
                //key: address, value: ankara
            }
            //get all the values
            var values = db.HashValues(hashkey);
            foreach (var item in values)
            {
                Console.WriteLine(string.Format("value:{0}", item));
            }
            //get all the keys
            var keys = db.HashKeys(hashkey);

            foreach (var k in keys)
            {
                Console.WriteLine(k);
            }
            //HashLength
            var len = db.HashLength(hashkey);
            Console.WriteLine(len);

            if (db.HashExists(hashkey, "age"))
            {
                var age = db.HashIncrement(hashkey, "age", 2); //age now becomes 28
                Console.WriteLine(age);

            }
            Console.ReadKey();
        }
    }
}
