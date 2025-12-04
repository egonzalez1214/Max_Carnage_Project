// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Max_Carnage_ProjectEditorTarget : TargetRules {
    public Max_Carnage_ProjectEditorTarget(TargetInfo Target) : base(Target) {
        Type = TargetType.Editor;

        DefaultBuildSettings = BuildSettingsVersion.Latest;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

        ExtraModuleNames.AddRange(new string[] { "Max_Carnage_Project" });
    }
}

