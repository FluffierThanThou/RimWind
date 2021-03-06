﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using RimWorld.Planet;

namespace RimTES
{
    class BiomeWorker_GashForest : BiomeWorker
    {
        public override float GetScore(Tile tile)
        {
            if (tile.WaterCovered)
                return -100f;
            if (tile.temperature < -10f)
                return 0f;
            if (tile.rainfall < 600f)
                return 0f;

            return 15f + (tile.temperature - 7f) + (tile.rainfall - 600f) / 180f;
        }
    }
}
