using System.Reflection;
using HarmonyLib;
using Verse;

namespace CutPlantsBeforeBuilding;

[StaticConstructorOnStartup]
internal static class Main
{
    public static bool autoDesignatePlantsCutMode;

    static Main()
    {
        autoDesignatePlantsCutMode = true;
        new Harmony("com.tammybee.cutplantsbeforebuilding").PatchAll(Assembly.GetExecutingAssembly());
    }
}