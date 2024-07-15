using System.Reflection;
using HarmonyLib;
using Verse;

namespace CutPlantsBeforeBuilding;

[StaticConstructorOnStartup]
internal static class Main
{
    public static bool AutoDesignatePlantsCutMode;
    public static bool ExtractEnabled;

    static Main()
    {
        AutoDesignatePlantsCutMode = CutPlantsBeforeBuildingMod.instance.Settings.DefaultMode;
        new Harmony("com.tammybee.cutplantsbeforebuilding").PatchAll(Assembly.GetExecutingAssembly());
    }
}