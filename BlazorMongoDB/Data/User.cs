using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlazorMongoDB.Data
{
    public class User
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString(); // ID único para MongoDB

        public string Username { get; set; } // Nombre de usuario
        public string Password { get; set; } // Contraseña en texto plano (para simplificar)
    }
}
