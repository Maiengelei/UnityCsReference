// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
    [VisibleToOtherModules("UnityEditor.UIBuilderModule")]
    internal enum StyleValueFunction
    {
        Unknown,
        Var,
        Env,
        LinearGradient
    }

    internal static class StyleValueFunctionExtension
    {
        public const string k_Var = "var";
        public const string k_Env = "env";
        public const string k_LinearGradient = "linear-gradient";

        public static StyleValueFunction FromUssString(string ussValue)
        {
            ussValue = ussValue.ToLowerInvariant();
            switch (ussValue)
            {
                case k_Var:
                    return StyleValueFunction.Var;
                case k_Env:
                    return StyleValueFunction.Env;
                case k_LinearGradient:
                    return StyleValueFunction.LinearGradient;
                default:
                    throw new ArgumentOutOfRangeException(nameof(ussValue), ussValue, "Unknown function name");
            }
        }

        public static string ToUssString(this StyleValueFunction svf)
        {
            switch (svf)
            {
                case StyleValueFunction.Var:
                    return k_Var;
                case StyleValueFunction.Env:
                    return k_Env;
                case StyleValueFunction.LinearGradient:
                    return k_LinearGradient;
                default:
                    throw new ArgumentOutOfRangeException(nameof(svf), svf, $"Unknown {nameof(StyleValueFunction)}");
            }
        }
    }
}
