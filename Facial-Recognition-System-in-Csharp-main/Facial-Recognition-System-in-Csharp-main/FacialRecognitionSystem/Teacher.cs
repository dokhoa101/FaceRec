using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace check
{
    internal class Teacher
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public List<ObjectId> classids { get; set; }
    }
}
