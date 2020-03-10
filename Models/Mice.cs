using System;

namespace AnimalLockUp
{
    public class Mice : IAboveGround
    {
        public string Size { get; set; }
        public string Name { get; set; }
        public string Legs { get; set; }
        public string LiveAboveGround { get; set; }

        public override string ToString()
        {
            return $"I am a {Name}.";
        }
    }
}
