using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;


namespace check
{
    internal class student  
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public string picture { get; set; }
        public string MSSV { get; set; }
        public object classId { get; set; }
        public DateTime birth { get; set; }
    }
}
