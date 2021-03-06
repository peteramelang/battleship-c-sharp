﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class AI : Player
    {

        public AI(OutputManager oManager, Game game) : base(ref oManager, game) { }

        public void PlaceShips()
        {
            foreach (Ship ship in ships)
            {
                // logic for intelligent placement of ships

                bool shipPlaceable;

                int shipLength = ship.GetLength();
                int[][] coordinates = new int[shipLength][];

                do
                {
                    coordinates = GetNewCoordinates(shipLength);
                    shipPlaceable = IsShipPlaceable(coordinates);
                } while (!shipPlaceable);

                ship.SetCoordinates(coordinates);
            }

            game.board.UpdateData(this);
            game.Print();
        }

        int[][] GetNewCoordinates(int shipLength)
        {
            Random random = new Random();

            int x = random.Next(0, 10);
            int y = random.Next(0, 10);

            int[][] coordinates = new int[shipLength][];

            coordinates[0] = new int[] { x, y };

            int directionX = random.Next(-1, 2);
            int directionY = 0;

            if (directionX == 0)
            {
                do
                {
                    directionY = random.Next(-1, 2);
                } while (directionY == 0);
            }          

            for (int i = 1; i < shipLength; i++)
            {
                x += directionX;
                y += directionY;

                coordinates[i] = new int[] { x, y };
            }

            return coordinates;
        }



    }
}
