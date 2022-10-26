using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace IKVM.Runtime
{
    public static class AotInitializer
    {
        public static IReadOnlyDictionary<Assembly, Assembly[]> AssemblyReferenceOverride { get; set; }

        public static AssemblyName[] GetReferencedAssembliesWithOverride(this Assembly asm)
        {
            if (AssemblyReferenceOverride == null)
            {
                return asm.GetReferencedAssemblies();
            }

            if (!AssemblyReferenceOverride.ContainsKey(asm))
            {
                return new AssemblyName[0];
            }

            return AssemblyReferenceOverride[asm].Select(refAsm => refAsm.GetName()).ToArray();
        }
    }
}
