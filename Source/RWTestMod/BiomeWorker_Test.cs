using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld.Planet;

namespace RWTestMod
{
    public class BiomeWorker_Test : BiomeWorker
    {
        public override float GetScore(BiomeDef biome, Tile tile, PlanetTile planetTile)
        {
            if (!tile.WaterCovered)
            {
                return 100f;
            }

            return -100f;
        }
    }


    public class BiomeWorker_NoTest : BiomeWorker
    {
        public override float GetScore(BiomeDef biome, Tile tile, PlanetTile planetTile)
        {
            if (tile.WaterCovered)
            {
                return -100f;
            }

            return 100f;
        }
    }
}