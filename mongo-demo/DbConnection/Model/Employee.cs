using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mongo_demo.DbConnection.Model
{
    public class Employee
    {
        [BsonId]
        public Guid Id { get; set; } = Guid.NewGuid();

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("age")]
        public int Age { get; set; }

        [BsonElement("experience")]
        public int Experience { get; set; }
    }
}
