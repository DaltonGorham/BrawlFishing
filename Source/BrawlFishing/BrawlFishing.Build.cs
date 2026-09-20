// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class BrawlFishing : ModuleRules
{
	public BrawlFishing(ReadOnlyTargetRules Target) : base(Target)
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
			"BrawlFishing",
			"BrawlFishing/Variant_Platforming",
			"BrawlFishing/Variant_Platforming/Animation",
			"BrawlFishing/Variant_Combat",
			"BrawlFishing/Variant_Combat/AI",
			"BrawlFishing/Variant_Combat/Animation",
			"BrawlFishing/Variant_Combat/Gameplay",
			"BrawlFishing/Variant_Combat/Interfaces",
			"BrawlFishing/Variant_Combat/UI",
			"BrawlFishing/Variant_SideScrolling",
			"BrawlFishing/Variant_SideScrolling/AI",
			"BrawlFishing/Variant_SideScrolling/Gameplay",
			"BrawlFishing/Variant_SideScrolling/Interfaces",
			"BrawlFishing/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
