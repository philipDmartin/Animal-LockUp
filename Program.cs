using System;
using System.Collections.Generic;

namespace AnimalLockUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ants myAnts = new Ants();
            BettaFish myBettaFish = new BettaFish();
            CopperheadSnake myCopperheadSnake = new CopperheadSnake();
            Earthworms myEarthworms = new Earthworms();
            Finches myFinches = new Finches();
            Gerbils myGerbils = new Gerbils();
            Mice Mice = new Mice();
            Parakeet myParakeet = new Parakeet();
            RattleSnake myRattleSnake = new RattleSnake();
            Terrapins myTerrapins = new Terrapins();

            Cage MyCage = new Cage();
            List<IAboveGround> Arrangment = MyCage.MakeAboveGroundCage();
        }
    }
}
