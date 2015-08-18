using System;

namespace Sharper.C.Lang.Typeclass
{
    [AttributeUsage(AttributeTargets.Parameter|AttributeTargets.Field)]
    public sealed class WithAttribute
        : Attribute
    {
    }
}