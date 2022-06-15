using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace On_Board_Computer
{
    public static class dbconnect
    {
        public static MongoClient client = client = new MongoClient("mongodb://localhost:27017");
        public static IMongoDatabase db = client.GetDatabase("xwingsimulator");        
    }
}
