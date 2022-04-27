using System;
using System.Collections.Generic;

namespace DogFactsSamples
{
    public class MeFactData
    {
        public MeFactData()
        {
        }
        public static IEnumerable<MeFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string TheImage { get; set; }
        static MeFactData()
        {
            List<MeFactData> all = new List<MeFactData>();
            all.Add(new MeFactData() { TheFact = "Noodles", ShortFact = "My Favorite Food", TheImage="" });
            all.Add(new MeFactData() { TheFact = "South Carolina", ShortFact = "My Favorite State", TheImage = "" });
            all.Add(new MeFactData() { TheFact = "Milky Ways", ShortFact = "My Favorite Candy", TheImage = "" });
            all.Add(new MeFactData() { TheFact = "Visual Basic", ShortFact = "My Least Favorite Programming Language", TheImage = "" });
            all.Add(new MeFactData() { TheFact = "blue", ShortFact = "The Colors of my Eyes", TheImage = "" });
            All = all;

        }
    }
}