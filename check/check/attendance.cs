using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;


namespace check
{
    class attendance
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public ObjectId classId {  get; set; }
        
        public ObjectId teacherid { get; set; }
        public string picture { get; set; }

        public DateTime createdat { get; set; }

        public object report { get; set; }
    }
}
