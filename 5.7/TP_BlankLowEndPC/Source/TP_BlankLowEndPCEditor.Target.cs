// Copyright (c) 2025 serpenteno. Licensed under MIT License.

using UnrealBuildTool;
using System.Collections.Generic;

public class TP_BlankLowEndPCEditorTarget : TargetRules
{
	public TP_BlankLowEndPCEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V6;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_7;
		ExtraModuleNames.Add("TP_BlankLowEndPC");
	}
}
