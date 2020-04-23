# StackExchange.Redis-dotnet-core
Redis Hash Datatype – Operations
HSET: Sets the value of a field for a key O(1).
HGET: Gets the value of a field for a key O(1).
HLEN: Gets the number of fields for the key O(1).
HMGET: Gets the values for the fields for a key O(N), where N is the number of fields and O (1) if N is small.
HMSET: Sets multiple values for respective fields for a key O(N), where N is the number of fields and O (1) if N is small.
HGETALL: Gets all the values and fields for a key O(N). Where N is the size of the hash
HKEYS: Gets all the fields in the Hash for the key O(1).
HEXISTS: Checks for the existence of a field for a key O(1).
HVALS: Gets all the values in the Hash for the key O(N), where N is the number of fields and O(1) if N is small.
HSETNX: Sets the value against the field for the key provided the field does not exist O(1).
HDEL: Deletes the fields for a key O (N), where N is the number of fields and O(1) if N is small.
HINCRBY: Increments the value (provided the value is an integer) of a field for a key O(1).
HINCRBYFLOAT: Increments the value if value is a float of a field for a key O(1).
C# code using Redis Hash Datatype
