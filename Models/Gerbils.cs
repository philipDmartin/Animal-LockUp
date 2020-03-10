using System;

namespace AnimalLockUp
{
    public class Gerbils : IUnderGround
    {
        public string Size { get; set; }
        public string Name { get; set; }
        public string Legs { get; set; }
        public string LiveUnderGround { get; set; }

        public override string ToString()
        {
            return $"I am a {Name}.";
        }
    }
}
