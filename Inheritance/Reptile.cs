using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

        }

        public bool HasShell { get; set; }
        public bool IsAmphibious { get; set; }

        public string ColorScales { get; set; }
        public bool IsColdBlooded { get; set; }

        public Reptile(int avglifespan, int legs, bool iscoveredinfur, bool isomnivore, bool hasshell, bool isamphibious, string colorscales, bool iscoldblooded)
        {
            AvgLifeSpan = avglifespan;
            Legs = legs;
            IsCoveredInFur = iscoveredinfur;
            IsOmnivore = isomnivore;
            HasShell = hasshell;
            IsAmphibious = isamphibious;
            ColorScales = colorscales;
            IsColdBlooded = iscoldblooded;
        }
    }


}
