using HarmonyLib;
using RimWorld;
using Verse;
using Verse.Sound;

namespace CutPlantsBeforeBuilding.HarmonyPatches;

[HarmonyPatch(typeof(PlaySettings), nameof(PlaySettings.DoPlaySettingsGlobalControls))]
internal class PlaySettings_DoPlaySettingsGlobalControls
{
    private static void Prefix(WidgetRow row, bool worldView)
    {
        if (MyKeyBindingDefOf.TMB_ToggleAutoDesignatePlantsCutMode.JustPressed)
        {
            Main.AutoDesignatePlantsCutMode = !Main.AutoDesignatePlantsCutMode;
            if (Main.AutoDesignatePlantsCutMode)
            {
                SoundDefOf.Tick_High.PlayOneShotOnCamera();
            }
            else
            {
                SoundDefOf.Tick_Low.PlayOneShotOnCamera();
            }
        }

        if (worldView)
        {
            return;
        }

        var toggleable = Main.AutoDesignatePlantsCutMode;
        var buttonAutoDesignatePlantsCutMode = MyTex.ButtonAutoDesignatePlantsCutMode;
        var mainKeyLabel = MyKeyBindingDefOf.TMB_ToggleAutoDesignatePlantsCutMode.MainKeyLabel;
        string text = toggleable
            ? "CutPlantsBeforeBuilding.ModeON".Translate()
            : "CutPlantsBeforeBuilding.ModeOFF".Translate();
        string tooltip =
            "CutPlantsBeforeBuilding.AutoDesignatePlantsCutModeToggleButton".Translate(mainKeyLabel, text);
        row.ToggleableIcon(ref toggleable, buttonAutoDesignatePlantsCutMode, tooltip,
            SoundDefOf.Mouseover_ButtonToggle);
        Main.AutoDesignatePlantsCutMode = toggleable;
    }
}