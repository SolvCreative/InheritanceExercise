using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }

        public bool Flies { get; set; }
        public int InchesWingSpan { get; set; }
        public string FeatherColor { get; set; }
        public string NestMadeOf { get; set; }

        public Bird(int avglifespan, int legs, bool iscoveredinfur, bool isomnivore, bool flies, int incheswingspan, string feathercolor, string nestmadeof)
        {
            AvgLifeSpan = avglifespan;
            Legs = legs;
            IsCoveredInFur = iscoveredinfur;
            IsOmnivore = isomnivore;
            Flies = flies;
            InchesWingSpan = incheswingspan;
            FeatherColor = feathercolor;
            NestMadeOf = nestmadeof;
        }
    }
}
