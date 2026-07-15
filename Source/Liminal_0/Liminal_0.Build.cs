// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Liminal_0 : ModuleRules
{
	public Liminal_0(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Liminal_0",
			"Liminal_0/Variant_Horror",
			"Liminal_0/Variant_Horror/UI",
			"Liminal_0/Variant_Shooter",
			"Liminal_0/Variant_Shooter/AI",
			"Liminal_0/Variant_Shooter/UI",
			"Liminal_0/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
