﻿using Mlie;
using UnityEngine;
using Verse;

namespace CutPlantsBeforeBuilding;

[StaticConstructorOnStartup]
internal class CutPlantsBeforeBuildingMod : Mod
{
    /// <summary>
    ///     The instance of the settings to be read by the mod
    /// </summary>
    public static CutPlantsBeforeBuildingMod Instance;

    private static string currentVersion;

    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="content"></param>
    public CutPlantsBeforeBuildingMod(ModContentPack content) : base(content)
    {
        Instance = this;
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
        var listingStandard = new Listing_Standard();
        listingStandard.Begin(rect);
        listingStandard.Gap();
        listingStandard.CheckboxLabeled("CutPlantsBeforeBuilding.DefaultMode".Translate(), ref Settings.DefaultMode,
            "CutPlantsBeforeBuilding.DefaultModeTT".Translate());
        listingStandard.CheckboxLabeled("CutPlantsBeforeBuilding.DigUp".Translate(), ref Settings.DigUp,
            "CutPlantsBeforeBuilding.DigUpTT".Translate());
        listingStandard.CheckboxLabeled("CutPlantsBeforeBuilding.OnlyCutters".Translate(), ref Settings.OnlyCutters,
            "CutPlantsBeforeBuilding.OnlyCuttersTT".Translate());
        listingStandard.CheckboxLabeled("CutPlantsBeforeBuilding.NoInfo".Translate(), ref Settings.NoInfo,
            "CutPlantsBeforeBuilding.NoInfoTT".Translate());
        if (currentVersion != null)
        {
            listingStandard.Gap();
            GUI.contentColor = Color.gray;
            listingStandard.Label("CutPlantsBeforeBuilding.CurrentModVersion".Translate(currentVersion));
            GUI.contentColor = Color.white;
        }

        listingStandard.End();
    }
}