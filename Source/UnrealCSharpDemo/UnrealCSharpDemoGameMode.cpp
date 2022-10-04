// Copyright Epic Games, Inc. All Rights Reserved.

#include "UnrealCSharpDemoGameMode.h"
#include "UnrealCSharpDemoHUD.h"
#include "UnrealCSharpDemoCharacter.h"
#include "UObject/ConstructorHelpers.h"

AUnrealCSharpDemoGameMode::AUnrealCSharpDemoGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPersonCPP/Blueprints/FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

	// use our custom HUD class
	HUDClass = AUnrealCSharpDemoHUD::StaticClass();
}
