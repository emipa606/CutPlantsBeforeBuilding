using Verse;

namespace CutPlantsBeforeBuilding;

/// <summary>
///     Definition of the settings for the mod
/// </summary>
internal class CutPlantsBeforeBuildingSettings : ModSettings
{
    public bool DefaultMode = true;
    public bool DigUp;
    public bool OnlyCutters = true;

    /// <summary>
    ///     Saving and loading the values
    /// </summary>
    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref DefaultMode, "DefaultMode", true);
        Scribe_Values.Look(ref OnlyCutters, "OnlyCutters", true);
        Scribe_Values.Look(ref DigUp, "DigUp");
    }
}