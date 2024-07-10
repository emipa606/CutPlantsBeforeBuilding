using UnityEngine;
using Verse;

namespace CutPlantsBeforeBuilding;

[StaticConstructorOnStartup]
public static class MyTex
{
    public static readonly Texture2D ButtonAutoDesignatePlantsCutMode =
        ContentFinder<Texture2D>.Get("UI/Buttons/AutoDesignatePlantsCutMode");
}