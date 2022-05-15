using System;
using System.Collections.Generic;
using SQLite;

namespace DogFactsSamples
{
    public class MeFactData
    {
        [PrimaryKey, AutoIncrement]
        public static IEnumerable<MeFactData> All { private set; get; }
        public int ID { get; set; }
        public string ShortFact { get; set; }
        public string AnImage { get; set; }
        static MeFactData()
        {


        }
    }
}