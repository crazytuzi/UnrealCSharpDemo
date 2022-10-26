using System;
using Script.Engine;
using Script.Reflection.Property;

namespace Script.Game
{
    public partial class ATestPropertyActor : AActor
    {
        public UInt16 UInt16Value
        {
            get
            {
                PropertyUtils.GetProperty(this, "UInt16Value", out UInt16 value);

                return value;
            }

            set => PropertyUtils.SetProperty(this, "UInt16Value", value);
        }

        public UInt32 UInt32Value
        {
            get
            {
                PropertyUtils.GetProperty(this, "UInt32Value", out UInt32 value);

                return value;
            }

            set => PropertyUtils.SetProperty(this, "UInt32Value", value);
        }

        // @TODO Int8

        public Int16 Int16Value
        {
            get
            {
                PropertyUtils.GetProperty(this, "Int16Value", out Int16 value);

                return value;
            }

            set => PropertyUtils.SetProperty(this, "Int16Value", value);
        }

        public Int32 Int32Value
        {
            get
            {
                PropertyUtils.GetProperty(this, "Int32Value", out Int32 value);

                return value;
            }

            set => PropertyUtils.SetProperty(this, "Int32Value", value);
        }

        public Int64 Int64Value
        {
            get
            {
                PropertyUtils.GetProperty(this, "Int64Value", out Int64 value);

                return value;
            }

            set => PropertyUtils.SetProperty(this, "Int64Value", value);
        }

        public bool BoolValue
        {
            get
            {
                PropertyUtils.GetProperty(this, "BoolValue", out bool value);

                return value;
            }

            set => PropertyUtils.SetProperty(this, "BoolValue", value);
        }

        public float FloatValue
        {
            get
            {
                PropertyUtils.GetProperty(this, "FloatValue", out float value);

                return value;
            }

            set => PropertyUtils.SetProperty(this, "FloatValue", value);
        }

        public UObject ObjectValue
        {
            get
            {
                PropertyUtils.GetProperty(this, "ObjectValue", out UObject value);

                return value;
            }

            set => PropertyUtils.SetProperty(this, "ObjectValue", value);
        }

        public double DoubleValue
        {
            get
            {
                PropertyUtils.GetProperty(this, "DoubleValue", out double value);

                return value;
            }

            set => PropertyUtils.SetProperty(this, "DoubleValue", value);
        }
    }
}