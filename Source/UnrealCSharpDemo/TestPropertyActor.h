// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "TestPropertyActor.generated.h"

UCLASS()
class UNREALCSHARPDEMO_API ATestPropertyActor : public AActor
{
	GENERATED_BODY()

public:
	// Sets default values for this actor's properties
	ATestPropertyActor();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:
	// Called every frame
	virtual void Tick(float DeltaTime) override;

public:
	UPROPERTY()
	uint16 UInt16Value;

	UPROPERTY()
	uint32 UInt32Value;

	UPROPERTY()
	int8 Int8Value;

	UPROPERTY()
	int16 Int16Value;

	UPROPERTY()
	int32 IntValue;

	UPROPERTY()
	int64 Int64Value;

	UPROPERTY()
	bool BoolValue;

	UPROPERTY()
	float FloatValue;

	UPROPERTY()
	UObject* ObjectValue;

	UPROPERTY()
	TArray<int32> ArrayValue;

	UPROPERTY()
	double DoubleValue;
};
