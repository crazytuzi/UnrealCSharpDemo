// Fill out your copyright notice in the Description page of Project Settings.


#include "TestFunctionActor.h"

// Sets default values
ATestFunctionActor::ATestFunctionActor()
{
	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
}

// Called when the game starts or when spawned
void ATestFunctionActor::BeginPlay()
{
	Super::BeginPlay();
}

// Called every frame
void ATestFunctionActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}

void ATestFunctionActor::TestEmpty()
{
	UE_LOG(LogTemp, Log, TEXT("%s %s %d"), *FString(__FUNCTION__), *FString(__FILE__), __LINE__);
}
