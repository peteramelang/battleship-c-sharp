﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Ship
    {
        int length;
        Dictionary<string, int> coordinates = new Dictionary<string, int>();
        string status;
        string type;
        
        public Ship(string shipType)
        {
            this.type = shipType;
            this.length = length;
        }

        public Dictionary<string, int> Place(int[,] coordinates)
        {
            this.coordinates.Add("x", coordinates[0,0]);
            this.coordinates.Add("y", coordinates[0,1]);

            return this.coordinates;
        }

        public bool IsSet()
        {
            return coordinates.Count > 0 && coordinates != null;
        }

    }
}
