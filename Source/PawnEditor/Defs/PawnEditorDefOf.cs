﻿using RimWorld;
using Verse;

namespace PawnEditor;

[DefOf]
public static class PawnEditorDefOf
{
    public static TabGroupDef Humanlike;
    public static TabGroupDef AnimalMech;
    public static TabGroupDef PlayerFaction;
    public static TabGroupDef NPCFaction;
    public static TabDef Gear;
    public static BodyPartGroupDef Hands;
    public static BodyPartDef Tail;

    static PawnEditorDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(PawnEditorDefOf));
    }
}
