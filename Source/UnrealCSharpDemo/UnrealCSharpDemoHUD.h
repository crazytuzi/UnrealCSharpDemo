// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once 

#include "CoreMinimal.h"
#include "GameFramework/HUD.h"
#include "UnrealCSharpDemoHUD.generated.h"

UCLASS()
class AUnrealCSharpDemoHUD : public AHUD
{
	GENERATED_BODY()

public:
	AUnrealCSharpDemoHUD();

	/** Primary draw call for the HUD */
	virtual void DrawHUD() override;

private:
	/** Crosshair asset pointer */
	class UTexture2D* CrosshairTex;

};

