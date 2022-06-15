using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace On_Board_Computer
{
    public class hyperspaceRoutesCollection
    {

        private static IMongoCollection<hyperspaceRoute> RoutesCollection = dbconnect.db.GetCollection<hyperspaceRoute>("hyperspaceRoutes");

        public static List<hyperspaceRoute> SelectAllRoutes()
        {
            List<hyperspaceRoute> regions = RoutesCollection.Find(c => true).ToList();

            return regions;

        }

    }
}
