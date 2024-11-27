using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace BlazorMongoDB.Data
{
    public class Comment
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();
        public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
