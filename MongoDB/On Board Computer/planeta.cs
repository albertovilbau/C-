using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace On_Board_Computer
{
    public class planeta
    {
        
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("filiation")]
        public String filiation { get; set; }

        [BsonElement("hyperspaceRoute")]
        public PlanethyperSpaceRoute hyperspaceRoute { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("natives")]
        public string natives { get; set; }

        [BsonElement("sector")]
        public string sector { get; set; }

        [BsonElement("situation")]
        public situation situacion { get; set; }

    }

    public class situation
    {
        [BsonElement("long")]
        public String longitud;

        [BsonElement("lat")]
        public String latitud;

        [BsonElement("parsecs")]
        public String parsecs;        
    }

    public class PlanethyperSpaceRoute
    {
        [BsonElement("route")]
        public String[] route;
    }

}
