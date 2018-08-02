// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class CameraSwitchBetween4Target : TargetRules
{
	public CameraSwitchBetween4Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "CameraSwitchBetween4" } );
	}
}
