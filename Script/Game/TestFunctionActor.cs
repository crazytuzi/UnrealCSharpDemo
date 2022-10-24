using System;
using Script.Proxy.Game;

namespace Script.Game
{
    public class ATestFunctionActor : ATestFunctionActorProxy
    {
        public void ReceiveBeginPlay()
        {
            Console.WriteLine("ATestFunctionActor::ReceiveBeginPlay");

            TestEmpty();
        }
    }
}