﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using RimWorld;
using Verse;

namespace RimTES
{
    public class TagDef : ThingDef
    {
        // Maybe doesn't need constructors?
        public TagDef() { thingClass = typeof(Tag); }
        public TagDef(Type thingClass) { this.thingClass = thingClass; }










        public override IEnumerable<StatDrawEntry> SpecialDisplayStats()
        {
            foreach (StatDrawEntry stat in base.SpecialDisplayStats())
                yield return stat;
        }

        public override IEnumerable<string> ConfigErrors()
        {
            foreach (string error in base.ConfigErrors())
                yield return error;
        }

        public override void ClearCachedData() { base.ClearCachedData(); }
        public override string ToString() { return base.ToString(); }
        public override int GetHashCode() { return base.GetHashCode(); }
        public override void ResolveReferences() { base.ResolveReferences(); }
        public override void PostLoad() { base.PostLoad(); }
    }
}
