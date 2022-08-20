using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Course.Services.Catalog.Models
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] //Bu tip MongoDB'ye hangi özellikte olacağını belirtmek için verildi
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedDate { get; set; }
        public Feature Feature { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }

        [BsonIgnore] //Üstteki satırları MongoDB'ye yansıtırken alltakini gözardı et anlamına geliyor
        public Category Category { get; set; }
    }
}