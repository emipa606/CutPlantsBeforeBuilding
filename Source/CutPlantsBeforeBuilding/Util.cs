using System.Collections.Generic;
using RimWorld;
using Verse;

namespace CutPlantsBeforeBuilding;

internal class Util
{
    private static readonly List<ThingDef> notAllowedTrees =
    [
        ThingDefOf.Plant_TreeAnima,
        ThingDefOf.Plant_TreeHarbinger,
        ThingDefOf.Plant_TreeGauranlen
    ];

    public static void DesignatePlants(IntVec3 c, Rot4 rot, BuildableDef buildableDef, ThingDef stuffDef, Map map)
    {
        if (DebugSettings.godMode || buildableDef.GetStatValueAbstract(StatDefOf.WorkToBuild, stuffDef) == 0f)
        {
            return;
        }

        var thingDef = buildableDef as ThingDef;
        var size = IntVec2.One;
        if (thingDef != null)
        {
            size = thingDef.size;
        }

        DesignatePlants(c, rot, size, map);
    }

    public static void DesignatePlants(IntVec3 c, Rot4 rot, IntVec2 size, Map map)
    {
        foreach (var item in GenAdj.OccupiedRect(c, rot, size))
        {
            DesignatePlant(item, map);
        }
    }

    public static void DesignatePlant(IntVec3 c, Map map)
    {
        if (!Main.autoDesignatePlantsCutMode)
        {
            return;
        }

        var plant = FindBlockingPlant(c, map);
        if (plant == null)
        {
            return;
        }

        if (notAllowedTrees.Contains(plant.def))
        {
            Messages.Message("CutPlantsBeforeBuilding.SpecialTree".Translate(plant.LabelCap), plant,
                MessageTypeDefOf.RejectInput);
            return;
        }

        DesignatePlant(plant, map);
    }

    private static void DesignatePlant(Plant plant, Map map)
    {
        map.designationManager.RemoveAllDesignationsOn(plant);
        map.designationManager.AddDesignation(plant.HarvestableNow
            ? new Designation(plant, DesignationDefOf.HarvestPlant)
            : new Designation(plant, DesignationDefOf.CutPlant));
    }

    private static Plant FindBlockingPlant(IntVec3 c, Map map)
    {
        var plant = c.GetPlant(map);
        if (plant != null && plant.def.plant.harvestWork >= 200f)
        {
            return plant;
        }

        return null;
    }
}