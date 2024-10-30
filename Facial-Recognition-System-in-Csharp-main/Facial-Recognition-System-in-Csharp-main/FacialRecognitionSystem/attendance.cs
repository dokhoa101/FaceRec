using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Collections.Generic;
using System;


namespace check
{
    class attendance
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public ObjectId classId { get; set; }

        public ObjectId teacherid { get; set; }

        public DateTime createdat { get; set; }

        public List<reportItem> report { get; set; }
    }

    class reportItem
    {
        public ObjectId studentid { get; set; }
        public string status { get; set; }
        public DateTime? time { get; set; }
    }
}
