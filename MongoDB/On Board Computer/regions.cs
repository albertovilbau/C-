using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace On_Board_Computer
{
    public class regions
    {

        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("descriptionRegion")]
        public String descriptionRegion { get; set; }

        [BsonElement("mapRegion")]
        public String mapRegion { get; set; }

        [BsonElement("nameRegion")]
        public String nameRegion { get; set; }

    }
}
