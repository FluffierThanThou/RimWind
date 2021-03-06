﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using RimWorld.Planet;

namespace RimTES
{
    class BiomeWorker_Sheogorad : BiomeWorker
    {
        public override float GetScore(Tile tile)
        {
            if (tile.WaterCovered)
                return -100f;
            if (tile.temperature < -10f)
                return 0f;
            if (tile.swampiness < 0.5f)
                return 0f;

            return -tile.temperature + 13f + tile.swampiness * 8f;
        }
    }
}
