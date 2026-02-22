using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace Tidewrack
{
    public class CompGatherable : CompHasGatherableBodyResource
    {
        protected override int GatherResourcesIntervalDays => Props.gatherIntervalDays;

        protected override int ResourceAmount => Props.itemAmount;

        protected override ThingDef ResourceDef => Props.itemDef;

        protected override string SaveKey => "gatherableProduction";

        public CompProperties_Gatherable Props => (CompProperties_Gatherable)props;

        protected override bool Active
        {
            get
            {
                if (!base.Active)
                {
                    return false;
                }
                Pawn pawn = parent as Pawn;
                if (pawn != null && !pawn.ageTracker.CurLifeStage.shearable)
                {
                    return false;
                }
                if (ModsConfig.AnomalyActive && pawn.IsShambler)
                {
                    return false;
                }
                return true;
            }
        }

        public override string CompInspectStringExtra()
        {
            if (!Active)
            {
                return null;
            }
            return Props.growthLabel + ": " + base.Fullness.ToStringPercent();
        }
    }

    public class CompProperties_Gatherable : CompProperties
    {
        public int gatherIntervalDays;
        public int itemAmount = 1;
        public ThingDef itemDef;
        public string growthLabel;
        public float workAmount = 1700f;

        public CompProperties_Gatherable()
        {
            compClass = typeof(CompGatherable);
        }
    }
}
