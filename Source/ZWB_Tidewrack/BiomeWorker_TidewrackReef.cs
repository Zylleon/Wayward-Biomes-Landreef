using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld.Planet;

namespace Tidewrack
{
    public class BiomeWorker_TidewrackReef : BiomeWorker
    {
        public override float GetScore(BiomeDef biome, Tile tile, PlanetTile planetTile)
        {
            if (tile.WaterCovered)
            {
                return -100f;
            }
            if (tile.temperature < -8f)
            {
                return 0f;
            }
            if (tile.elevation > 300f)
            {
                return 0f;
            }
            if (tile.rainfall < 1000f)
            {
                return 0f;
            }
            if (tile.rainfall > 2200f)
            {
                return 0f;
            }
            if (tile.swampiness > 0.3f || tile.swampiness < 0.0f)
            {
                return 0f;
            }
            if (tile.swampiness > 0.11f && tile.swampiness < 0.18f)
            {
                return 0f;
            }

            return 37 - (tile.elevation / 9f) + 2f * (tile.temperature - 18f);

        }

    }

}