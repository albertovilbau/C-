using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace On_Board_Computer
{
    public class PlanetasCollection
    {

        private static IMongoCollection<planeta> planetaCollection = dbconnect.db.GetCollection<planeta>("planets");

        public static List<planeta> SelectAllPlanets()
        {
            List<planeta> planetas = planetaCollection.Find(c => true).ToList();

            return planetas;

        }

    }
}
