using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace On_Board_Computer
{
    public class hyperspaceRoute
    {

        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("nameRoute")]
        public String nameRoute { get; set; }

        [BsonElement("start")]
        public String start { get; set; }

        [BsonElement("end")]
        public String end { get; set; }

        [BsonElement("type")]
        public String type { get; set; }

    }
}
