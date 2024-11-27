using System;
using System.Collections.Generic;

namespace BlazorMongoDB.Data
{
    public class Order
    {
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Generar un identificador único
        public List<Product> Products { get; set; } = new List<Product>();
        public string PaymentMethod { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Pendiente"; // Estados: Pendiente, Procesado, Completado
    }
}
