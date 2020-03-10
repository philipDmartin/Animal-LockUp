using System;

namespace AnimalLockUp
{
    public class Terrapins : IInTheSky
    {
        public string Size { get; set; }
        public string Name { get; set; }
        public string Legs { get; set; }
        public string LiveInTheSky { get; set; }

        public override string ToString()
        {
            return $"I am a {Name}.";
        }
    }
}
