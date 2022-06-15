using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace On_Board_Computer
{
    public class RegionsCollection
    {

        private static IMongoCollection<regions> regionsCollection = dbconnect.db.GetCollection<regions>("regions");

        public static List<regions> SelectAllRegions()
        {
            List<regions> regions = regionsCollection.Find(c => true).ToList();

            return regions;

        }

    }
}
