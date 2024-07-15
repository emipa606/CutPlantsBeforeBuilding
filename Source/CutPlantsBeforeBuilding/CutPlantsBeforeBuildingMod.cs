using Mlie;
using UnityEngine;
using Verse;

namespace CutPlantsBeforeBuilding;

[StaticConstructorOnStartup]
internal class CutPlantsBeforeBuildingMod : Mod
{
    /// <summary>
    ///     The instance of the settings to be read by the mod
    /// </summary>
    public static CutPlantsBeforeBuildingMod instance;

    private static string currentVersion;

    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="content"></param>
    public CutPlantsBeforeBuildingMod(ModContentPack content) : base(content)
    {
        instance = this;
        Settings = GetSettings<CutPlantsBeforeBuildingSettings>();
        currentVersion = VersionFromManifest.GetVersionFromModMetaData(content.ModMetaData);
    }

    /// <summary>
    ///     The instance-settings for the mod
    /// </summary>
    internal CutPlantsBeforeBuildingSettings Settings { get; }

    /// <summary>
    ///     The title for the mod-settings
    /// </summary>
    /// <returns></returns>
    public override string SettingsCategory()
    {
        return "Cut Plants Before Building";
    }

    /// <summary>
    ///     The settings-window
    ///     For more info: https://rimworldwiki.com/wiki/Modding_Tutorials/ModSettings
    /// </summary>
    /// <param name="rect"></param>
    public override void DoSettingsWindowContents(Rect rect)
    {
        var listing_Standard = new Listing_Standard();
        listing_Standard.Begin(rect);
        listing_Standard.Gap();
        listing_Standard.CheckboxLabeled("CutPlantsBeforeBuilding.DefaultMode".Translate(), ref Settings.DefaultMode,
            "CutPlantsBeforeBuilding.DefaultModeTT".Translate());
        listing_Standard.CheckboxLabeled("CutPlantsBeforeBuilding.DigUp".Translate(), ref Settings.DigUp,
            "CutPlantsBeforeBuilding.DigUpTT".Translate());
        if (currentVersion != null)
        {
            listing_Standard.Gap();
            GUI.contentColor = Color.gray;
            listing_Standard.Label("CutPlantsBeforeBuilding.CurrentModVersion".Translate(currentVersion));
            GUI.contentColor = Color.white;
        }

        listing_Standard.End();
    }
}