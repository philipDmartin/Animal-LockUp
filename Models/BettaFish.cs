using System;

namespace AnimalLockUp
{
    public class BettaFish : IUnderWater
    {
        public string Size { get; set; }
        public string Name { get; set; }
        public string Legs { get; set; }
        public string LiveUnderWater { get; set; }

        public override string ToString()
        {
            return $"I am a {Name}.";
        }
    }
}
