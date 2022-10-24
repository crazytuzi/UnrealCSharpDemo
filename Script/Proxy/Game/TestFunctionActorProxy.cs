using Script.Proxy.Engine;
using Script.Reflection.Function;

namespace Script.Proxy.Game
{
    public class ATestFunctionActorProxy : AActorProxy
    {
        public void TestEmpty()
        {
            FunctionUtils.CallReflectionFunction(this, "TestEmpty");
        }
    }
}