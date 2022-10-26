using System;
using Script.Engine;

namespace Script.Game
{
    public partial class ATestFunctionActor : AActor
    {
        public void ReceiveBeginPlay()
        {
            Console.WriteLine("ATestFunctionActor::ReceiveBeginPlay");

            TestEmpty();
        }
    }
}