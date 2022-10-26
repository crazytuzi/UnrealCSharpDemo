using System;

namespace Script.Game
{
    public partial class ATestPropertyActor
    {
        public void ReceiveBeginPlay()
        {
            Console.WriteLine("ATestPropertyActor::ReceiveBeginPlay");

            {
                Console.WriteLine("Get UInt16Value Start");

                Console.WriteLine(UInt16Value);

                Console.WriteLine("Get UInt16Value End");

                Console.WriteLine("Set UInt16Value Start");

                UInt16Value = 2;

                Console.WriteLine("Set UInt16Value End");

                Console.WriteLine("Get UInt16Value Start");

                Console.WriteLine(UInt16Value);

                Console.WriteLine("Get UInt16Value End");
            }

            {
                Console.WriteLine("Get UInt32Value Start");

                Console.WriteLine(UInt32Value);

                Console.WriteLine("Get UInt32Value End");

                Console.WriteLine("Set UInt32Value Start");

                UInt32Value = 2;

                Console.WriteLine("Set UInt32Value End");

                Console.WriteLine("Get UInt32Value Start");

                Console.WriteLine(UInt32Value);

                Console.WriteLine("Get UInt32Value End");
            }

            {
                Console.WriteLine("Get Int16Value Start");

                Console.WriteLine(Int16Value);

                Console.WriteLine("Get Int16Value End");

                Console.WriteLine("Set Int16Value Start");

                Int16Value = 2;

                Console.WriteLine("Set Int16Value End");

                Console.WriteLine("Get Int16Value Start");

                Console.WriteLine(Int16Value);

                Console.WriteLine("Get Int16Value End");
            }

            {
                Console.WriteLine("Get Int32Value Start");

                Console.WriteLine(Int32Value);

                Console.WriteLine("Get Int32Value End");

                Console.WriteLine("Set Int32Value Start");

                Int32Value = 2;

                Console.WriteLine("Set Int32Value End");

                Console.WriteLine("Get Int32Value Start");

                Console.WriteLine(Int32Value);

                Console.WriteLine("Get Int32Value End");
            }

            {
                Console.WriteLine("Get Int64Value Start");

                Console.WriteLine(Int64Value);

                Console.WriteLine("Get Int64Value End");

                Console.WriteLine("Set Int64Value Start");

                Int64Value = 2;

                Console.WriteLine("Set Int64Value End");

                Console.WriteLine("Get Int64Value Start");

                Console.WriteLine(Int64Value);

                Console.WriteLine("Get Int64Value End");
            }

            {
                Console.WriteLine("Get BoolValue Start");

                Console.WriteLine(BoolValue);

                Console.WriteLine("Get BoolValue End");

                Console.WriteLine("Set BoolValue Start");

                BoolValue = true;

                Console.WriteLine("Set BoolValue End");

                Console.WriteLine("Get BoolValue Start");

                Console.WriteLine(BoolValue);

                Console.WriteLine("Get BoolValue End");
            }

            {
                Console.WriteLine("Get FloatValue Start");

                Console.WriteLine(FloatValue);

                Console.WriteLine("Get FloatValue End");

                Console.WriteLine("Set FloatValue Start");

                FloatValue = 2.0f;

                Console.WriteLine("Set FloatValue End");

                Console.WriteLine("Get FloatValue Start");

                Console.WriteLine(FloatValue);

                Console.WriteLine("Get FloatValue End");
            }
            
            {
                Console.WriteLine("Get ObjectValue Start");

                Console.WriteLine(ObjectValue);

                Console.WriteLine("Get ObjectValue End");

                Console.WriteLine("Set ObjectValue Start");

                ObjectValue = this;

                Console.WriteLine("Set ObjectValue End");

                Console.WriteLine("Get ObjectValue Start");

                Console.WriteLine(ObjectValue);

                Console.WriteLine("Get ObjectValue End");
            }

            {
                Console.WriteLine("Get DoubleValue Start");

                Console.WriteLine(DoubleValue);

                Console.WriteLine("Get DoubleValue End");

                Console.WriteLine("Set DoubleValue Start");

                DoubleValue = 2.0;

                Console.WriteLine("Set DoubleValue End");

                Console.WriteLine("Get DoubleValue Start");

                Console.WriteLine(DoubleValue);

                Console.WriteLine("Get DoubleValue End");
            }
        }
    }
}