using System;
using System.Collections.Generic;

namespace AnimalLockUp
{
    public class Cage
    {
        public List<Ants> Ants = new List<Ants>();
        public List<BettaFish> BettaFish = new List<BettaFish>();
        public List<CopperheadSnake> CopperheadSnake = new List<CopperheadSnake>();
        public List<Earthworms> Earthworms = new List<Earthworms>();
        public List<Finches> Finches = new List<Finches>();
        public List<Gerbils> Gerbils = new List<Gerbils>();
        public List<Mice> Mice = new List<Mice>();
        public List<Parakeet> Parakeet = new List<Parakeet>();
        public List<RattleSnake> RattleSnake = new List<RattleSnake>();
        public List<Terrapins> Terrapins = new List<Terrapins>();

        public List<IUnderGround> MakeUnderGroundCage()
        {
            List<IUnderGround> Arrangment = new List<IUnderGround>();
            Arrangment.Add(new Ants());
            Arrangment.Add(new Gerbils());

            return Arrangment;
        }

        public List<IAboveGround> MakeAboveGroundCage()
        {
            List<IAboveGround> Arrangment = new List<IAboveGround>();
            Arrangment.Add(new CopperheadSnake());
            Arrangment.Add(new Earthworms());
            Arrangment.Add(new Mice());
            Arrangment.Add(new RattleSnake());

            return Arrangment;
        }
        public List<IUnderWater> MakeUnderWaterCage()
        {
            List<IUnderWater> Arrangment = new List<IUnderWater>();
            Arrangment.Add(new BettaFish());

            return Arrangment;
        }
        public List<IInTheSky> MakeInTheSkyCage()
        {
            List<IInTheSky> Arrangment = new List<IInTheSky>();
            Arrangment.Add(new Finches());
            Arrangment.Add(new Parakeet());
            Arrangment.Add(new Terrapins());

            return Arrangment;
        }
    }
}
