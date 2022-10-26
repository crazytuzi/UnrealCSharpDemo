using Script.Engine;
using Script.Reflection.Function;

namespace Script.Game
{
    public partial class ATestFunctionActor : AActor
    {
        public void TestEmpty()
        {
            FunctionUtils.CallReflectionFunction(this, "TestEmpty");
        }
    }
}