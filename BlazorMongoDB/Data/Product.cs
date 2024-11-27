using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace BlazorMongoDB.Data
{
    public class Product
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // Propiedad para identificar si un producto es destacado
        public bool IsFeatured { get; set; } = false;

        // Propiedad para almacenar la URL de la imagen del producto
        public string ImageUrl { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();
    }

    public class Review
    {
        public string UserName { get; set; }
        public string Comment { get; set; }
        public int Stars { get; set; } // Valor entre 1 y 5
    }
}
