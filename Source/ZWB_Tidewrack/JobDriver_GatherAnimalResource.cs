using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace Tidewrack
{
    internal class JobDriver_GatherAnimalResource : JobDriver_GatherAnimalBodyResources
    {
        protected override float WorkTotal => 600f;

        protected override CompHasGatherableBodyResource GetComp(Pawn animal)
        {
            return animal.TryGetComp<CompGatherable>();
        }
    }

    public class WorkGiver_GatherAnimalResource : WorkGiver_GatherAnimalBodyResources
    {
        protected override JobDef JobDef => TidewrackDefOf.ZWB_GatherAnimalResource;

        protected override CompHasGatherableBodyResource GetComp(Pawn animal)
        {
            return animal.TryGetComp<CompGatherable>();
        }
    }



}