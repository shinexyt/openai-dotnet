// <auto-generated/>

#nullable disable

using System;

namespace OpenAI
{
    [AttributeUsage((AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct))]
    internal partial class CodeGenTypeAttribute : Attribute
    {
        public CodeGenTypeAttribute(string originalName)
        {
            OriginalName = originalName;
        }

        public string OriginalName { get; }
    }
}
