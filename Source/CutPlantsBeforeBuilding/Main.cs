using System.Reflection;
using HarmonyLib;
using Verse;

namespace CutPlantsBeforeBuilding;

[StaticConstructorOnStartup]
internal static class Main
{
    public static bool AutoDesignatePlantsCutMode;

    static Main()
    {
        AutoDesignatePlantsCutMode = CutPlantsBeforeBuildingMod.Instance.Settings.DefaultMode;
        new Harmony("com.tammybee.cutplantsbeforebuilding").PatchAll(Assembly.GetExecutingAssembly());
    }
}